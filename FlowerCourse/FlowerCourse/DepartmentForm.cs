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
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();

            AddPanel.Visible = false;
            ChangePanel.Visible = false;

            DepartmentDataGridView.SelectionChanged += DepartmentDataGridView_SelectionChanged;
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.flower_databaseDataSet.Department);

            DepartmentDataGridView.Columns["iddepartmentDataGridViewTextBoxColumn"].HeaderText = "Идентификатор отдела";
            DepartmentDataGridView.Columns["nameDataGridViewTextBoxColumn"].HeaderText = "Название отела";

            DepartmentDataGridView.SelectionChanged += DepartmentDataGridView_SelectionChanged;
        }

        private void OpenAddPanel_Click(object sender, EventArgs e)
        {
            AddPanel.Visible=true;
        }

        private void OpenChangePanel_Click(object sender, EventArgs e)
        {
            ChangePanel.Visible=true;
        }

        private void DeleteDepButton_Click(object sender, EventArgs e)
        {
            if (DepartmentDataGridView.SelectedRows.Count > 0)
            {
                int depID = (int)DepartmentDataGridView.SelectedRows[0].Cells["iddepartmentDataGridViewTextBoxColumn"].Value;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string deleteOrderQuery = "DELETE FROM [dbo].[Department] WHERE [id_department] = @id_department";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, database.getConnection());
                    deleteOrderCommand.Parameters.AddWithValue("@id_department", depID);
                    deleteOrderCommand.ExecuteNonQuery();

                    this.departmentTableAdapter.Fill(this.flower_databaseDataSet.Department);

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = AddNameTextBox.Text;

            Database database = new Database();
            database.openConnection();

            try
            {
                string addDepartmentQuery = "INSERT INTO [dbo].[Department] ([name]) " +
                    "VALUES (@name)";

                SqlCommand insertOrderCommand = new SqlCommand(addDepartmentQuery, database.getConnection());
                insertOrderCommand.Parameters.AddWithValue("@name", name);

                insertOrderCommand.ExecuteNonQuery();

                this.departmentTableAdapter.Fill(this.flower_databaseDataSet.Department);

                MessageBox.Show("Заказ успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AddNameTextBox.Clear();

            database.closeConnection();

        }

        private void DepartmentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DepartmentDataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = DepartmentDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = DepartmentDataGridView.Rows[rowIndex];

                DepIDTextBox.Text = selectedRow.Cells["iddepartmentDataGridViewTextBoxColumn"].Value.ToString();
                ChangeNameTextBox.Text = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void ChangeDepButton_Click(object sender, EventArgs e)
        {
            if (DepartmentDataGridView.SelectedRows.Count > 0)
            {
                int id_department = (int)DepartmentDataGridView.SelectedRows[0].Cells["iddepartmentDataGridViewTextBoxColumn"].Value;

                string name = ChangeNameTextBox.Text;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string updateSalaryQuery = "UPDATE [dbo].[Department] SET [name] = @name WHERE [id_department] = @id_department";
                    SqlCommand updateCommand = new SqlCommand(updateSalaryQuery, database.getConnection());
                    updateCommand.Parameters.AddWithValue("@name", name);
                    updateCommand.Parameters.AddWithValue("@id_department", id_department);

                    updateCommand.ExecuteNonQuery();

                    this.departmentTableAdapter.Fill(this.flower_databaseDataSet.Department);

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
    }
}
