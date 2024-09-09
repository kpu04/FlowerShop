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
    public partial class PersonalAcc : Form
    {

        private int userId;
        private int idCustomer;

        public PersonalAcc(int userId, int idCustomer)
        {
            InitializeComponent();
            this.userId = userId;
            this.idCustomer = idCustomer;
            FillTextBoxes();
        }

        private void FillTextBoxes()
        {
            Database database = new Database();
            database.openConnection();

            try
            {
                string query = "SELECT id_customer FROM [dbo].[User] WHERE id_user = @userId";
                SqlCommand command = new SqlCommand(query, database.getConnection());
                command.Parameters.AddWithValue("@userId", userId);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    idCustomer = reader.GetInt32(0); 
                    reader.Close(); 
                }
                else
                {
                    reader.Close();                                                                                                        
                }

                query = "SELECT surname, name, address, ph_num, status FROM [dbo].[Customer] WHERE id_customer = @customerId";
                command = new SqlCommand(query, database.getConnection());
                command.Parameters.AddWithValue("@customerId", idCustomer);

                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    SurnameTextBox.Text = reader["surname"].ToString();
                    NameTextBox.Text = reader["name"].ToString();
                    AdressTextBox.Text = reader["address"].ToString();
                    PhNumTextBox.Text = reader["ph_num"].ToString();
                    StatusTextBox.Text = reader["status"].ToString();
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

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            SurnameTextBox.ReadOnly = false;
            NameTextBox.ReadOnly = false;
            AdressTextBox.ReadOnly = false;
            PhNumTextBox.ReadOnly = false;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            string surname = SurnameTextBox.Text;
            string name = NameTextBox.Text;
            string address = AdressTextBox.Text;
            string phoneNumber = PhNumTextBox.Text;

            Database database = new Database();

            try
            {
                database.openConnection();

                // Получаем id_customer для текущего пользователя
                string getUserIdQuery = "SELECT id_customer FROM [dbo].[User] WHERE id_user = @userId";
                SqlCommand getUserIdCommand = new SqlCommand(getUserIdQuery, database.getConnection());
                getUserIdCommand.Parameters.AddWithValue("@userId", userId);
                int idCustomer = 0;

                // Используем SqlDataReader для получения значения id_customer
                using (SqlDataReader reader = getUserIdCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idCustomer = reader.GetInt32(0);
                    }
                }

                // Обновляем данные клиента в таблице Customer
                string updateCustomerQuery = @"UPDATE [dbo].[Customer] 
                                       SET surname = @surname, 
                                           name = @name, 
                                           address = @address, 
                                           ph_num = @phoneNumber 
                                       WHERE id_customer = @customerId";
                SqlCommand updateCustomerCommand = new SqlCommand(updateCustomerQuery, database.getConnection());
                updateCustomerCommand.Parameters.AddWithValue("@surname", surname);
                updateCustomerCommand.Parameters.AddWithValue("@name", name);
                updateCustomerCommand.Parameters.AddWithValue("@address", address);
                updateCustomerCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                updateCustomerCommand.Parameters.AddWithValue("@customerId", idCustomer); // Используем полученное значение id_customer
                updateCustomerCommand.ExecuteNonQuery();

                MessageBox.Show("Данные успешно обновлены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных: " + ex.Message);
            }
            finally
            {
                database.closeConnection();
            }

            // Устанавливаем поля только для чтения после обновления данных
            SurnameTextBox.ReadOnly = true;
            NameTextBox.ReadOnly = true;
            AdressTextBox.ReadOnly = true;
            PhNumTextBox.ReadOnly = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FlowerForm flower = new FlowerForm(userId, idCustomer);
            flower.Show();
            this.Hide();
        }
    }
}
