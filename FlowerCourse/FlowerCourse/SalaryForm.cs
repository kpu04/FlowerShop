using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerCourse
{
    public partial class SalaryForm : Form
    {
        private Dictionary<string, string> columnMappings = new Dictionary<string, string>()
        {
            { "Идентификатор зарплаты", "id_salary" },
            { "Количество часов (день)", "daytime_hours" },
            { "Количество часов (ночь)", "night_hours" },
            { "Оплата за час (день)", "pay_for_hour_d" },
            { "Оплата за час (ночь)", "pay_for_hour_n" },
            { "Идентификатор сотрудника", "id_employee" }
        };

        public SalaryForm()
        {
            InitializeComponent();

            AddSalaryPanel.Visible = false;
            ChangeSalaryPanel.Visible = false;
            SearchSalaryPanel.Visible = false;

            LoadColumnNamesToComboBox();

            SalaryDataGridView.SelectionChanged += SalaryDataGridView_SelectionChanged;

        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet.Salary". При необходимости она может быть перемещена или удалена.
            this.salaryTableAdapter.Fill(this.flower_databaseDataSet.Salary);

            SalaryDataGridView.Columns["idsalaryDataGridViewTextBoxColumn"].HeaderText = "Идентификатор зарплаты";
            SalaryDataGridView.Columns["daytimehoursDataGridViewTextBoxColumn"].HeaderText = "Количество часов (день)";
            SalaryDataGridView.Columns["nighthoursDataGridViewTextBoxColumn"].HeaderText = "Количество часов (ночь)";
            SalaryDataGridView.Columns["payforhourdDataGridViewTextBoxColumn"].HeaderText = "Оплата за час (день)";
            SalaryDataGridView.Columns["payforhournDataGridViewTextBoxColumn"].HeaderText = "Оплата за час (ночь)";
            SalaryDataGridView.Columns["idemployeeDataGridViewTextBoxColumn"].HeaderText = "Идентификатор сотрудника";

            SalaryDataGridView.SelectionChanged += SalaryDataGridView_SelectionChanged;

        }

        private void OpenAddSalaryButton_Click(object sender, EventArgs e)
        {
            AddSalaryPanel.Visible = true;
        }

        private void OpenChangeSalaryButton_Click(object sender, EventArgs e)
        {
            ChangeSalaryPanel.Visible = true;
        }

        private void OpenSearchSalaryButton_Click(object sender, EventArgs e)
        {
            SearchSalaryPanel.Visible = true;
        }

        private void AddSalaryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PayForDayTextBox.Text) || string.IsNullOrWhiteSpace(PayNightTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float dayhours = float.Parse(DayHoursTextBox.Text);
            float nighthours = float.Parse(NightHoursTextBox.Text);
            decimal payday = decimal.Parse(PayForDayTextBox.Text);
            decimal paynight = decimal.Parse(PayNightTextBox.Text);
            int emplId = int.Parse(EmployeeIDTextBox.Text);

            Database database = new Database();
            database.openConnection();

            try
            {
                string addSalaryQuery = "INSERT INTO [dbo].[Salary] ([daytime_hours], [night_hours], [pay_for_hour_d], [pay_for_hour_n], [id_employee]) " +
                    "VALUES (@dayhours, @nighthours, @payday, @paynight, @id_employee)";

                SqlCommand insertOrderCommand = new SqlCommand(addSalaryQuery, database.getConnection());
                insertOrderCommand.Parameters.AddWithValue("@dayhours", dayhours);
                insertOrderCommand.Parameters.AddWithValue("@nighthours", nighthours);
                insertOrderCommand.Parameters.AddWithValue("@payday", payday);
                insertOrderCommand.Parameters.AddWithValue("@paynight", paynight);
                insertOrderCommand.Parameters.AddWithValue("@id_employee", emplId);

                insertOrderCommand.ExecuteNonQuery();

                this.salaryTableAdapter.Fill(this.flower_databaseDataSet.Salary);

                MessageBox.Show("Заказ успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DayHoursTextBox.Clear();
            NightHoursTextBox.Clear();
            PayForDayTextBox.Clear();
            PayNightTextBox.Clear();
            EmployeeIDTextBox.Clear();

            database.closeConnection();

        }

        private void ChangeSalaryButton_Click(object sender, EventArgs e)
        {
            if (SalaryDataGridView.SelectedRows.Count > 0)
            {
                int salaryId = (int)SalaryDataGridView.SelectedRows[0].Cells[0].Value;

                float dayhours = float.Parse(DayHourChangeTextBox.Text);
                float nighthours = float.Parse(NightHourChangeTextBox.Text);
                decimal payday = decimal.Parse(PayForDayChangeTextBox.Text);
                decimal paynight = decimal.Parse(PayForNightChangeTextBox.Text);
                int emplId = int.Parse(EmplIDChangeTextBox.Text);

                Database database = new Database();
                database.openConnection();

                try
                {
                    string updateSalaryQuery = "UPDATE [dbo].[Salary] SET [daytime_hours] = @dayhours, [night_hours] = @nighthours, [pay_for_hour_d] = @payday, [pay_for_hour_n] = @paynight, [id_employee] = @emplId WHERE [id_salary] = @salaryId";
                    SqlCommand updateCommand = new SqlCommand(updateSalaryQuery, database.getConnection());
                    updateCommand.Parameters.AddWithValue("@dayhours", dayhours);
                    updateCommand.Parameters.AddWithValue("@nighthours", nighthours);
                    updateCommand.Parameters.AddWithValue("@payday", payday);
                    updateCommand.Parameters.AddWithValue("@paynight", paynight);
                    updateCommand.Parameters.AddWithValue("@emplId", emplId);
                    updateCommand.Parameters.AddWithValue("@salaryId", salaryId);

                    updateCommand.ExecuteNonQuery();

                    this.salaryTableAdapter.Fill(this.flower_databaseDataSet.Salary);

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

        private void DeleteSalaryButton_Click(object sender, EventArgs e)
        {
            if (SalaryDataGridView.SelectedRows.Count > 0)
            {
                int salaryId = (int)SalaryDataGridView.SelectedRows[0].Cells["idsalaryDataGridViewTextBoxColumn"].Value;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string deleteOrderQuery = "DELETE FROM [dbo].[Salary] WHERE [id_salary] = @id_salary";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, database.getConnection());
                    deleteOrderCommand.Parameters.AddWithValue("@id_salary", salaryId);
                    deleteOrderCommand.ExecuteNonQuery();

                    this.salaryTableAdapter.Fill(this.flower_databaseDataSet.Salary);

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
        private void SalaryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (SalaryDataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = SalaryDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = SalaryDataGridView.Rows[rowIndex];

                SalaryIDTextBox.Text = selectedRow.Cells["idsalaryDataGridViewTextBoxColumn"].Value.ToString();
                DayHourChangeTextBox.Text = selectedRow.Cells["daytimehoursDataGridViewTextBoxColumn"].Value.ToString();
                NightHourChangeTextBox.Text = selectedRow.Cells["nighthoursDataGridViewTextBoxColumn"].Value.ToString();
                PayForDayChangeTextBox.Text = selectedRow.Cells["payforhourdDataGridViewTextBoxColumn"].Value.ToString();
                PayForNightChangeTextBox.Text = selectedRow.Cells["payforhournDataGridViewTextBoxColumn"].Value.ToString();
                EmplIDChangeTextBox.Text = selectedRow.Cells["idemployeeDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string selectedColumnName = SearchSalaryComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Пожалуйста, выберите столбец для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string systemColumnName = columnMappings[selectedColumnName];

            string searchText = SearchSalaryTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Пожалуйста, введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchQuery = $"SELECT * FROM [dbo].[Salary] WHERE [{systemColumnName}] = @searchText";

            Database database = new Database();
            database.openConnection();

            try
            {
                SqlCommand searchCommand = new SqlCommand(searchQuery, database.getConnection());
                searchCommand.Parameters.AddWithValue("@searchText", searchText);

                SqlDataAdapter adapter = new SqlDataAdapter(searchCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                SalaryDataGridView.DataSource = dataTable;

                MessageBox.Show("Поиск завершен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении поиска: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            database.closeConnection();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            this.Hide();
        }

        private void LoadColumnNamesToComboBox()
        {
            SearchSalaryComboBox.Items.Add("Идентификатор зарплаты");
            SearchSalaryComboBox.Items.Add("Количество часов (день)");
            SearchSalaryComboBox.Items.Add("Количество часов (ночь)");
            SearchSalaryComboBox.Items.Add("Оплата за час (день)");
            SearchSalaryComboBox.Items.Add("Оплата за час (ночь)");
            SearchSalaryComboBox.Items.Add("Идентификатор сотрудника");
        }
    }
}
