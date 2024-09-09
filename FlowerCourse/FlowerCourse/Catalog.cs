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
    public partial class Catalog : Form
    {

        private int userId;
        private int idCustomer;

        public Catalog(int userId, int idCustomer)
        {
            InitializeComponent();
            this.userId = userId;
            this.idCustomer = idCustomer;
            CategoryComboBox.SelectedIndexChanged += CatalogComboBox_SelectedIndexChanged;

            ApplyOrderPanel.Hide();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet3.Composition". При необходимости она может быть перемещена или удалена.
     //       this.compositionTableAdapter1.Fill(this.flower_databaseDataSet3.Composition);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet1.Composition". При необходимости она может быть перемещена или удалена.
            this.compositionTableAdapter1.Fill(this.flower_databaseDataSet3.Composition);

            CatalogDataGridView.Columns["photoDataGridViewImageColumn"].HeaderText = "Фото";
            CatalogDataGridView.Columns["bouquetsnameDataGridViewTextBoxColumn"].HeaderText = "Название букета";
            CatalogDataGridView.Columns["makingdateDataGridViewTextBoxColumn"].HeaderText = "Дата сборки";
            CatalogDataGridView.Columns["categoryDataGridViewTextBoxColumn"].HeaderText = "Категория";
            CatalogDataGridView.Columns["priceDataGridViewTextBoxColumn"].HeaderText = "Стоимость";

           Database database = new Database();
   
           database.openConnection();
   
           try
           {
               string query = "SELECT MIN(price) AS MinPrice, MAX(price) AS MaxPrice FROM Composition";
   
               SqlCommand command = new SqlCommand(query, database.getConnection());
   
               SqlDataReader reader = command.ExecuteReader();
   
               if (reader.Read())
               {
                   decimal minPrice = (decimal)reader["MinPrice"];
                   decimal maxPrice = (decimal)reader["MaxPrice"];
   
                   MinSearchButton.Text = minPrice.ToString();
                   MaxSearchButton.Text = maxPrice.ToString();
               }
   
               reader.Close();
           }
   
           catch (Exception ex)
           {
               MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           finally
           {
               database.closeConnection();
           }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FlowerForm flower = new FlowerForm(userId, idCustomer);
            flower.Show();
            this.Hide();
        }

        private void SortDownButton_Click(object sender, EventArgs e)
        {
                DataView dataView = (DataView)compositionBindingSource1.List;

                dataView.Sort = "price DESC";
          
        }

        private void SortUpButton_Click(object sender, EventArgs e)
        {
            DataView dataView = (DataView)compositionBindingSource1.List;

            dataView.Sort = "price ASC";
        }

        private void CatalogComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null)
            {
                string selectedCategory = CategoryComboBox.SelectedItem.ToString();

                DataView dataView = (DataView)compositionBindingSource1.List;

                if (!string.IsNullOrEmpty(selectedCategory))
                {
                    dataView.RowFilter = $"category = '{selectedCategory}'";
                }
                else
                {
                    dataView.RowFilter = "";
                }

                this.compositionTableAdapter1.Fill(this.flower_databaseDataSet3.Composition);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.compositionTableAdapter1.Fill(this.flower_databaseDataSet3.Composition);

            DataView dataView = (DataView)compositionBindingSource1.List;
            dataView.RowFilter = "";

            dataView.Sort = "";
        }

        private void ApplySearchButton_Click(object sender, EventArgs e)
        {
            string minPriceStr = MinSearchButton.Text;
            string maxPriceStr = MaxSearchButton.Text;

            if (!double.TryParse(minPriceStr, out double minPrice) ||
                !double.TryParse(maxPriceStr, out double maxPrice))
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для цен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (minPrice > maxPrice)
            {
                MessageBox.Show("Минимальное значение цены не может быть больше максимального.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataView dataView = (DataView)compositionBindingSource1.List;

            string filterExpression = $"price >= {minPrice} AND price <= {maxPrice}";

            dataView.RowFilter = filterExpression;
        }

        private void ApplyOrder_Click(object sender, EventArgs e)
        {
            DataRowView selectedComposition = compositionBindingSource1.Current as DataRowView;
            if (selectedComposition == null)
            {
                MessageBox.Show("Пожалуйста, выберите строку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime selectedDate = DateOrderPicker.Value.Date;
            TimeSpan selectedTime = TimeSpan.Parse(TimeOrderTextBox.Text);

            int customerId;
            Database database = new Database();

            try
            {
                database.openConnection();

                string query = "SELECT id_customer, id_user FROM [User] WHERE id_user = @userId";
                SqlCommand command = new SqlCommand(query, database.getConnection());
                command.Parameters.AddWithValue("@userId", userId);
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out customerId))
                {

                }
                else
                {
                    MessageBox.Show("Ошибка извлечения данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в данных: " + ex.Message, "Ошиька", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                database.closeConnection();
            }

            int compositionId = (int)selectedComposition["id_bouquet"];

            string insertQuery = "INSERT INTO [Order] (data_of_order, id_customer, time_of_delivery, id_composition) " +
                "VALUES (@date, @customerId, @time, @compositionId)";

            try
            {
                database.openConnection();

                SqlCommand command = new SqlCommand(insertQuery, database.getConnection());
                command.Parameters.AddWithValue("@date", selectedDate);
                command.Parameters.AddWithValue("@customerId", customerId);
                command.Parameters.AddWithValue("@time", selectedTime);
                command.Parameters.AddWithValue("@compositionId", compositionId);
                command.ExecuteNonQuery();

                MessageBox.Show("Заказ успешно оформлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка оформления заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
             {
                ApplyOrderPanel.Show();
             }
    }
}
