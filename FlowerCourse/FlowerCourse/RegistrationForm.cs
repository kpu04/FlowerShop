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
    public partial class RegistrationForm : Form
    {
        private bool isPasswordVisible1 = false;
        private bool isPasswordVisible2 = false;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm autorization = new AuthorizationForm();
            autorization.Show();
            this.Hide();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string username = LoginTextBox.Text;
            string password = PasswordTextBox1.Text;
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string ph_num = PhoneTextBox.Text;
            string address = AdressTextBox.Text;
            string password2 = PasswordTextBox2.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(ph_num) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(password2))
            {
                MessageBox.Show("Пожалуйста, заполните все текстовые поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (password != password2)
            {
                MessageBox.Show("Пароли не совпадают. Пожалуйста, введите одинаковые пароли в оба поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            Database database = new Database();
            database.openConnection();

            string getMaxCustomerIdQuery = "SELECT MAX([id_customer]) FROM [dbo].[Customer]";
            SqlCommand getMaxCustomerIdCommand = new SqlCommand(getMaxCustomerIdQuery, database.getConnection());
            int maxCustomerId = Convert.ToInt32(getMaxCustomerIdCommand.ExecuteScalar());
            int newCustomerId = maxCustomerId + 1;

            string insertClientQuery = "INSERT INTO [dbo].[Customer] ([surname], [name], [address], [ph_num], [status]) " +
                                       "VALUES (@surname, @name, @address, @ph_num, 'новый')";
            SqlCommand insertClientCommand = new SqlCommand(insertClientQuery, database.getConnection());
            insertClientCommand.Parameters.AddWithValue("@name", name);
            insertClientCommand.Parameters.AddWithValue("@surname", surname);
            insertClientCommand.Parameters.AddWithValue("@address", address);
            insertClientCommand.Parameters.AddWithValue("@ph_num", ph_num);
            insertClientCommand.ExecuteNonQuery();

            string insertUserQuery = "INSERT INTO [dbo].[User] ([username], [password], [id_employee], [id_customer], [role]) " +
                                     "VALUES (@username, @password, NULL, @id_customer, 'клиент')";
            SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, database.getConnection());
            insertUserCommand.Parameters.AddWithValue("@username", username);
            insertUserCommand.Parameters.AddWithValue("@password", password);
            insertUserCommand.Parameters.AddWithValue("@id_customer", newCustomerId);
            insertUserCommand.ExecuteNonQuery();

            database.closeConnection();

            MessageBox.Show("Регистрация успешно завершена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
