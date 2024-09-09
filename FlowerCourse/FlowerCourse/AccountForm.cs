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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();

            AddPanel.Visible = false;
            ChangePanel.Visible = false;

            UserDataGridView.SelectionChanged += UserDataGridView_SelectionChanged;

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.flower_databaseDataSet.User);

            UserDataGridView.Columns["iduserDataGridViewTextBoxColumn"].HeaderText = "Идентификатор пользователя";
            UserDataGridView.Columns["usernameDataGridViewTextBoxColumn"].HeaderText = "Логин";
            UserDataGridView.Columns["idemployeeDataGridViewTextBoxColumn"].HeaderText = "Код сотрудника";
            UserDataGridView.Columns["idcustomerDataGridViewTextBoxColumn"].HeaderText = "Код клиента";
            UserDataGridView.Columns["passwordDataGridViewTextBoxColumn"].HeaderText = "Пароль";
            UserDataGridView.Columns["roleDataGridViewTextBoxColumn"].HeaderText = "Доступ";

            UserDataGridView.SelectionChanged += UserDataGridView_SelectionChanged;
        }

        private void OpenAddButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
        }

        private void OpenChangeButton_Click(object sender, EventArgs e)
        {
            ChangePanel.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (UserDataGridView.SelectedRows.Count > 0)
            {
                int userId = (int)UserDataGridView.SelectedRows[0].Cells["iduserDataGridViewTextBoxColumn"].Value;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string deleteOrderQuery = "DELETE FROM [dbo].[User] WHERE [id_user] = @id_user";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, database.getConnection());
                    deleteOrderCommand.Parameters.AddWithValue("@id_user", userId);
                    deleteOrderCommand.ExecuteNonQuery();

                    this.userTableAdapter.Fill(this.flower_databaseDataSet.User);

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddRoleComboBox.Text) || string.IsNullOrWhiteSpace(AddNameTextBox.Text) || string.IsNullOrWhiteSpace(PswdTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = AddNameTextBox.Text;
            string password = PswdTextBox.Text;
            int? emplID = null;
            int? custID = null;

            if (!string.IsNullOrWhiteSpace(AddIDempl.Text))
            {
                if (!int.TryParse(AddIDempl.Text, out int parsedEmplID))
                {
                    MessageBox.Show("Неверный формат идентификатора сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                emplID = parsedEmplID;
            }

            if (!string.IsNullOrWhiteSpace(AddIDCustTextBox.Text))
            {
                if (!int.TryParse(AddIDCustTextBox.Text, out int parsedCustID))
                {
                    MessageBox.Show("Неверный формат идентификатора клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                custID = parsedCustID;
            }

            string role = AddRoleComboBox.Text;

            Database database = new Database();
            database.openConnection();

            try
            {
                string addAccountQuery = "INSERT INTO [dbo].[User] ([username], [password], [id_employee], [id_customer], [role]) " +
                    "VALUES (@name, @password, @emplID, @custID, @role)";

                SqlCommand insertOrderCommand = new SqlCommand(addAccountQuery, database.getConnection());
                insertOrderCommand.Parameters.AddWithValue("@name", name);
                insertOrderCommand.Parameters.AddWithValue("@password", password);
                insertOrderCommand.Parameters.AddWithValue("@emplID", emplID ?? (object)DBNull.Value);
                insertOrderCommand.Parameters.AddWithValue("@custID", custID ?? (object)DBNull.Value);
                insertOrderCommand.Parameters.AddWithValue("@role", role);

                insertOrderCommand.ExecuteNonQuery();

                this.userTableAdapter.Fill(this.flower_databaseDataSet.User);

                MessageBox.Show("Аккаунт успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении аккаунта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AddNameTextBox.Clear();
            PswdTextBox.Clear();
            AddIDempl.Clear();
            AddIDCustTextBox.Clear();

            database.closeConnection();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (UserDataGridView.SelectedRows.Count > 0)
            {
                int userID = (int)UserDataGridView.SelectedRows[0].Cells["iduserDataGridViewTextBoxColumn"].Value;

                string username = ChangeLoginTextBox.Text;
                string password = ChangePswdTextBox.Text;
                string role = ChangeRoleComboBox.Text;
                int? custID = string.IsNullOrWhiteSpace(ChangeIDCustTextBox.Text) ? (int?)null : int.Parse(ChangeIDCustTextBox.Text);
                int? emplID = string.IsNullOrWhiteSpace(ChangeIDEmplTextBox.Text) ? (int?)null : int.Parse(ChangeIDEmplTextBox.Text);


                Database database = new Database();
                database.openConnection();

                try
                {
                    string updateEmployeeQuery = "UPDATE [dbo].[User] SET [username] = @username, [password] = @password, [role] = @role";

                    if (emplID.HasValue)
                    {
                        updateEmployeeQuery += ", [id_employee] = @emplID";
                    }
                    if (custID.HasValue)
                    {
                        updateEmployeeQuery += ", [id_customer] = @custID";
                    }

                    updateEmployeeQuery += " WHERE [id_user] = @userID";

                    SqlCommand updateCommand = new SqlCommand(updateEmployeeQuery, database.getConnection());
                    updateCommand.Parameters.AddWithValue("@password", password);
                    updateCommand.Parameters.AddWithValue("@username", username);
                    updateCommand.Parameters.AddWithValue("@role", role);
                    updateCommand.Parameters.AddWithValue("@userID", userID);

                    if (emplID.HasValue)
                    {
                        updateCommand.Parameters.AddWithValue("@emplID", emplID.Value);
                    }
                    if (custID.HasValue)
                    {
                        updateCommand.Parameters.AddWithValue("@custID", custID.Value);
                    }

                    updateCommand.ExecuteNonQuery();

                    this.userTableAdapter.Fill(this.flower_databaseDataSet.User);

                    MessageBox.Show("Изменения успешно сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                database.closeConnection();
            }
        }

            private void UserDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (UserDataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = UserDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = UserDataGridView.Rows[rowIndex];

                ChangeIDCustTextBox.Text = selectedRow.Cells["idcustomerDataGridViewTextBoxColumn"].Value.ToString();
                ChangeIDEmplTextBox.Text = selectedRow.Cells["idemployeeDataGridViewTextBoxColumn"].Value.ToString();
                ChangeLoginTextBox.Text = selectedRow.Cells["usernameDataGridViewTextBoxColumn"].Value.ToString();
                ChangePswdTextBox.Text = selectedRow.Cells["passwordDataGridViewTextBoxColumn"].Value.ToString();
                ChangeRoleComboBox.Text = selectedRow.Cells["roleDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdministratorForm administrator = new AdministratorForm();
            administrator.Show();
            this.Hide();
        }
    }
}
