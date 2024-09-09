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
    public partial class AuthorizationForm : Form
    {

        private bool isPasswordVisible = false;

        public AuthorizationForm()
        {
            InitializeComponent();
            PasswordTextBox.UseSystemPasswordChar = true;

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = isPasswordVisible;
            isPasswordVisible = !isPasswordVisible;
        }
        private void CreateAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            Database database = new Database();
            database.openConnection();

            try
            {
                string query = "SELECT role, id_user, id_customer FROM [dbo].[User] WHERE [username] = @username AND [password] = @password";
                SqlCommand command = new SqlCommand(query, database.getConnection());
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["role"].ToString();
                    int userId = Convert.ToInt32(reader["id_user"]);
                    int idCustomer;

                    if (!Convert.IsDBNull(reader["id_customer"]))
                    {
                        idCustomer = Convert.ToInt32(reader["id_customer"]);
                    }
                    else
                    {
                        idCustomer = 0; 
                    }


                    if (role == "администратор")
                    {
                        AdministratorForm AdminForm = new AdministratorForm();
                        AdminForm.Show();
                        this.Hide();
                    }
                    else if (role == "клиент")
                    {
                        FlowerForm flowerForm = new FlowerForm(userId, idCustomer);
                        flowerForm.UserIdPassed += (s, id) => 
                        {
                            PersonalAcc personalAccForm = new PersonalAcc(id, idCustomer);
                            personalAccForm.Show();
                        };
                        flowerForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неопределенная роль пользователя");
                    }
                }
                else
                {
                    MessageBox.Show("Неверные имя пользователя или пароль");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
        }
    }
}
