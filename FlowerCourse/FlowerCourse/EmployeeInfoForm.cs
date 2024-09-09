using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerCourse
{
    public partial class EmployeeInfoForm : Form
    {
        private Dictionary<string, string> columnMappings = new Dictionary<string, string>()
        {
            { "Идентификатор сотрудника", "id_employee" },
            { "Фамилия сотрудника", "surname_of_employee" },
            { "Имя сотрудника", "name_of_employee" },
            { "Номер телефона", "ph_num" },
            { "Должность", "job_title" },
            { "Отдел", "id_department" }
        };

        Dictionary<string, string> FillComboBox = new Dictionary<string, string>()
        {
            { "Отдел управления", "1" },
            { "Отдел управления заказами и доставкой", "2" },
            { "Отдел инвентаризации и учёта", "3" },
            { "Отдел создания букетов и композиций", "4" }
        };

        public EmployeeInfoForm()
        {
            InitializeComponent();

            AddEmployeePanel.Visible = false;
            ChangeEmployeePanel.Visible = false;
            SearchEmployeePanel.Visible = false;

            EmployeeDataGridView.Columns["idemployeeDataGridViewTextBoxColumn"].HeaderText = "Идентификатор сотрудника";
            EmployeeDataGridView.Columns["surnameofemployeeDataGridViewTextBoxColumn"].HeaderText = "Фамилия сотрудника";
            EmployeeDataGridView.Columns["nameofemployeeDataGridViewTextBoxColumn"].HeaderText = "Имя сотрудника";
            EmployeeDataGridView.Columns["phnumDataGridViewTextBoxColumn"].HeaderText = "Номер телефона";
            EmployeeDataGridView.Columns["jobtitleDataGridViewTextBoxColumn"].HeaderText = "Должность";
            EmployeeDataGridView.Columns["iddepartmentDataGridViewTextBoxColumn"].HeaderText = "Отдел";

            DepartmentComboBox.DataSource = new BindingSource(FillComboBox, null);
            DepartmentComboBox.DisplayMember = "Key";
            DepartmentComboBox.ValueMember = "Value";

            ChangeDepartmentEmployeeComboBox.DataSource = new BindingSource(FillComboBox, null);
            ChangeDepartmentEmployeeComboBox.DisplayMember = "Key";
            ChangeDepartmentEmployeeComboBox.ValueMember = "Value";

            EmployeeDataGridView.SelectionChanged += EmployeeDataGridView_SelectionChanged;
        }

        private void EmployeeInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.flower_databaseDataSet.Employee);

            EmployeeDataGridView.SelectionChanged += EmployeeDataGridView_SelectionChanged;

            foreach (string columnName in columnMappings.Keys)
            {
                SearchInfoComboBox.Items.Add(columnName);
            }
        }

        private void OpenAddButton_Click(object sender, EventArgs e)
        {
            AddEmployeePanel.Visible = true;
        }

        private void OpenChangeButton_Click(object sender, EventArgs e)
        {
            ChangeEmployeePanel.Visible = true;
        }

        private void OpenSearchButton_Click(object sender, EventArgs e)
        {
            SearchEmployeePanel.Visible = true;
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeeDataGridView.SelectedRows.Count > 0)
            {
                int emplID = (int)EmployeeDataGridView.SelectedRows[0].Cells["idemployeeDataGridViewTextBoxColumn"].Value;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string deleteOrderQuery = "DELETE FROM [dbo].[Employee] WHERE [id_employee] = @emplID";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, database.getConnection());
                    deleteOrderCommand.Parameters.AddWithValue("@emplID", emplID);
                    deleteOrderCommand.ExecuteNonQuery();

                    this.employeeTableAdapter.Fill(this.flower_databaseDataSet.Employee);

                    MessageBox.Show("Информация успешно удалена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении информации: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                database.closeConnection();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddSurnameTextBox.Text) || string.IsNullOrWhiteSpace(AddNameTextBox.Text) || string.IsNullOrWhiteSpace(AddPhNumTextBox.Text) || string.IsNullOrWhiteSpace(TitleComboBox.Text) || string.IsNullOrWhiteSpace(DepartmentComboBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string surname = AddSurnameTextBox.Text;
            string name = AddNameTextBox.Text;
            string phone = AddPhNumTextBox.Text;
            string title = TitleComboBox.Text;
            int dep = int.Parse(((KeyValuePair<string, string>)DepartmentComboBox.SelectedItem).Value);

            Database database = new Database();
            database.openConnection();

            try
            {
                string addSalaryQuery = "INSERT INTO [dbo].[Employee] ([surname_of_employee], [name_of_employee], [ph_num], [job_title], [id_department]) " +
                    "VALUES (@surname, @name, @phone, @title, @dep)";

                SqlCommand insertOrderCommand = new SqlCommand(addSalaryQuery, database.getConnection());

                insertOrderCommand.Parameters.AddWithValue("@surname", surname);
                insertOrderCommand.Parameters.AddWithValue("@name", name);
                insertOrderCommand.Parameters.AddWithValue("@phone", phone);
                insertOrderCommand.Parameters.AddWithValue("@title", title);
                insertOrderCommand.Parameters.AddWithValue("@dep", dep);

                insertOrderCommand.ExecuteNonQuery();

                this.employeeTableAdapter.Fill(this.flower_databaseDataSet.Employee);

                MessageBox.Show("Заказ успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AddSurnameTextBox.Clear();
            AddNameTextBox.Clear();
            AddPhNumTextBox.Clear();

            database.closeConnection();
        }
        private void ChangeEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeeDataGridView.SelectedRows.Count > 0)
            {
                int emplID = (int)EmployeeDataGridView.SelectedRows[0].Cells["idemployeeDataGridViewTextBoxColumn"].Value;

                string surname = ChangeSurnameTextBox.Text;
                string name = ChangeNameTextBox.Text;
                string phone = ChangePhNumTextBox.Text;
                string title = ChangeTitleComboBox.Text;
                int dep = int.Parse(((KeyValuePair<string, string>)ChangeDepartmentEmployeeComboBox.SelectedItem).Value);

                Database database = new Database();
                database.openConnection();

                try
                {
                    string updateEmployeeQuery = "UPDATE [dbo].[Employee] SET [surname_of_employee] = @surname, [name_of_employee] = @name, [ph_num] = @phone, [job_title] = @title, [id_department] = @dep WHERE [id_employee] = @emplID";
                    SqlCommand updateCommand = new SqlCommand(updateEmployeeQuery, database.getConnection());
                    updateCommand.Parameters.AddWithValue("@surname", surname);
                    updateCommand.Parameters.AddWithValue("@name", name);
                    updateCommand.Parameters.AddWithValue("@phone", phone);
                    updateCommand.Parameters.AddWithValue("@title", title);
                    updateCommand.Parameters.AddWithValue("@dep", dep);
                    updateCommand.Parameters.AddWithValue("@emplID", emplID);

                    updateCommand.ExecuteNonQuery();

                    this.employeeTableAdapter.Fill(this.flower_databaseDataSet.Employee);

                    MessageBox.Show("Изменения успешно сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                database.closeConnection();

            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EmployeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (EmployeeDataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = EmployeeDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = EmployeeDataGridView.Rows[rowIndex];

                ChangeIDEmployeeTextBox.Text = selectedRow.Cells["idemployeeDataGridViewTextBoxColumn"].Value.ToString();
                ChangeNameTextBox.Text = selectedRow.Cells["nameofemployeeDataGridViewTextBoxColumn"].Value.ToString();
                ChangeSurnameTextBox.Text = selectedRow.Cells["surnameofemployeeDataGridViewTextBoxColumn"].Value.ToString();
                ChangePhNumTextBox.Text = selectedRow.Cells["phnumDataGridViewTextBoxColumn"].Value.ToString();
                ChangeTitleComboBox.Text = selectedRow.Cells["jobtitleDataGridViewTextBoxColumn"].Value.ToString();
                ChangeDepartmentEmployeeComboBox.Text = selectedRow.Cells["iddepartmentDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            this.Hide();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string selectedColumnName = SearchInfoComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Пожалуйста, выберите столбец для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string systemColumnName = columnMappings[selectedColumnName];

            string searchText = InfoTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Пожалуйста, введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchQuery = $"SELECT * FROM [dbo].[Employee] WHERE [{systemColumnName}] LIKE @searchText";

            Database database = new Database();
            database.openConnection();

            try
            {
                SqlCommand searchCommand = new SqlCommand(searchQuery, database.getConnection());
                searchCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(searchCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                EmployeeDataGridView.DataSource = dataTable;

                MessageBox.Show("Поиск завершен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении поиска: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            database.closeConnection();
        }


    }
}
