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
    public partial class CustomerForm : Form
    {
        private Dictionary<string, string> columnMappings = new Dictionary<string, string>()
        {
            { "Идентификатор клиента", "id_customer" },
            { "Фамилия клиента", "surname" },
            { "Имя клиента", "name" },
            { "Адрес", "address" },
            { "Номер телефона", "ph_num" },
            { "Статус", "status" }
        };

        public CustomerForm()
        {
            InitializeComponent();

            AddPanel.Visible = false;
            ChangePanel.Visible = false;
            OpenSearch.Visible = false;

            CustomerDataGridView.Columns["idcustomerDataGridViewTextBoxColumn"].HeaderText = "Идентификатор клиента";
            CustomerDataGridView.Columns["surnameDataGridViewTextBoxColumn"].HeaderText = "Фамилия клиента";
            CustomerDataGridView.Columns["nameDataGridViewTextBoxColumn"].HeaderText = "Имя клиента";
            CustomerDataGridView.Columns["addressDataGridViewTextBoxColumn"].HeaderText = "Адрес";
            CustomerDataGridView.Columns["phnumDataGridViewTextBoxColumn"].HeaderText = "Номер телефона";
            CustomerDataGridView.Columns["statusDataGridViewTextBoxColumn"].HeaderText = "Статус";

            CustomerDataGridView.SelectionChanged += CustomerDataGridView_SelectionChanged;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            SearchComboBox.Items.AddRange(columnMappings.Keys.ToArray());

            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.flower_databaseDataSet.Customer);

            CustomerDataGridView.SelectionChanged += CustomerDataGridView_SelectionChanged;
        }

        private void OpenAddPanel_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
        }

        private void OpenChangeButton_Click(object sender, EventArgs e)
        {
            ChangePanel.Visible = true;
        }

        private void DeleteCustButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count > 0)
            {
                int custID = (int)CustomerDataGridView.SelectedRows[0].Cells["idcustomerDataGridViewTextBoxColumn"].Value;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string deleteUserQuery = "DELETE FROM [dbo].[User] WHERE [id_customer] = @custID";
                    SqlCommand deleteUserCommand = new SqlCommand(deleteUserQuery, database.getConnection());
                    deleteUserCommand.Parameters.AddWithValue("@custID", custID);
                    deleteUserCommand.ExecuteNonQuery();

                    string deleteCustomerQuery = "DELETE FROM [dbo].[Customer] WHERE [id_customer] = @custID";
                    SqlCommand deleteCustomerCommand = new SqlCommand(deleteCustomerQuery, database.getConnection());
                    deleteCustomerCommand.Parameters.AddWithValue("@custID", custID);
                    deleteCustomerCommand.ExecuteNonQuery();

                    string deleteOrderQuery = "DELETE FROM [dbo].[Order] WHERE [id_customer] = @custID";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, database.getConnection());
                    deleteOrderCommand.Parameters.AddWithValue("@custID", custID);
                    deleteOrderCommand.ExecuteNonQuery();

                    this.customerTableAdapter.Fill(this.flower_databaseDataSet.Customer);

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

        private void OpenSearchButton_Click(object sender, EventArgs e)
        {
            OpenSearch.Visible = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddNameTextBox.Text) || string.IsNullOrWhiteSpace(AddNumTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string surname = AddSurnameTextBox.Text;
            string name = AddNameTextBox.Text;
            string phone = AddNumTextBox.Text;
            string adress = AddAdressTextBox.Text;
            string status = AddStatusComboBox.Text;

            Database database = new Database();
            database.openConnection();

            try
            {
                string addSalaryQuery = "INSERT INTO [dbo].[Customer] ([surname], [name], [ph_num], [address], [status]) " +
                    "VALUES (@surname, @name, @phone, @adress, @status)";

                SqlCommand insertOrderCommand = new SqlCommand(addSalaryQuery, database.getConnection());
                insertOrderCommand.Parameters.AddWithValue("@surname", surname);
                insertOrderCommand.Parameters.AddWithValue("@name", name);
                insertOrderCommand.Parameters.AddWithValue("@phone", phone);
                insertOrderCommand.Parameters.AddWithValue("@adress", adress);
                insertOrderCommand.Parameters.AddWithValue("@status", status);

                insertOrderCommand.ExecuteNonQuery();

                this.customerTableAdapter.Fill(this.flower_databaseDataSet.Customer);

                MessageBox.Show("Клиент успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении клиента: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AddSurnameTextBox.Clear();
            AddNameTextBox.Clear();
            AddAdressTextBox.Clear();
            AddNumTextBox.Clear();

            database.closeConnection();
        }

        private void CustomerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = CustomerDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = CustomerDataGridView.Rows[rowIndex];

                ChangeIDCustTextBox.Text = selectedRow.Cells["idcustomerDataGridViewTextBoxColumn"].Value.ToString();
                ChangeNameTextBox.Text = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                ChangeSurnameTextBox.Text = selectedRow.Cells["surnameDataGridViewTextBoxColumn"].Value.ToString();
                ChangeNumberTextBox.Text = selectedRow.Cells["phnumDataGridViewTextBoxColumn"].Value.ToString();
                ChangeAdressTextBox.Text = selectedRow.Cells["addressDataGridViewTextBoxColumn"].Value.ToString();
                ChangeStatusComboBox.Text = selectedRow.Cells["statusDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count > 0)
            {
                int custID = (int)CustomerDataGridView.SelectedRows[0].Cells["idcustomerDataGridViewTextBoxColumn"].Value;

                string surname = ChangeSurnameTextBox.Text;
                string name = ChangeNameTextBox.Text;
                string phone = ChangeNumberTextBox.Text;
                string adress = ChangeAdressTextBox.Text;
                string status = ChangeStatusComboBox.Text;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string updateEmployeeQuery = "UPDATE [dbo].[Customer] SET [surname] = @surname, [name] = @name, [ph_num] = @phone, [address] = @adress, [status] = @status WHERE [id_customer] = @custID";
                    SqlCommand updateCommand = new SqlCommand(updateEmployeeQuery, database.getConnection());
                    updateCommand.Parameters.AddWithValue("@surname", surname);
                    updateCommand.Parameters.AddWithValue("@name", name);
                    updateCommand.Parameters.AddWithValue("@phone", phone);
                    updateCommand.Parameters.AddWithValue("@adress", adress);
                    updateCommand.Parameters.AddWithValue("@status", status);
                    updateCommand.Parameters.AddWithValue("@custID", custID);

                    updateCommand.ExecuteNonQuery();

                    this.customerTableAdapter.Fill(this.flower_databaseDataSet.Customer);

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string selectedColumnName = SearchComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Пожалуйста, выберите столбец для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string systemColumnName = columnMappings[selectedColumnName];

            string searchText = SearchInfoTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Пожалуйста, введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchQuery = $"SELECT * FROM [dbo].[Customer] WHERE [{systemColumnName}] LIKE @searchText";

            Database database = new Database();
            database.openConnection();

            try
            {
                SqlCommand searchCommand = new SqlCommand(searchQuery, database.getConnection());
                searchCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(searchCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                CustomerDataGridView.DataSource = dataTable;

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
            AdministratorForm administrator = new AdministratorForm();
            administrator.Show();
            this.Hide();
        }
    }
}
