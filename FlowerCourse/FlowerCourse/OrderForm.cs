using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FlowerCourse
{
    public partial class OrderForm : Form
    {
        private Dictionary<string, string> columnMappings = new Dictionary<string, string>()
    {
        { "Номер заказа", "id_order" },
        { "Дата доставки", "data_of_order" },
        { "Идентификатор пользователя", "id_customer" },
        { "Время доставки", "time_of_delivery" },
        { "Номер позиции", "id_composition" }
    };
        public OrderForm()
        {
            InitializeComponent();

            AddOrderPanel.Visible = false;
            ChangeOrderInfoPanel.Visible = false;
            OrderSearchPanel.Visible = false;

            LoadColumnNamesToComboBox();

            OrderDataGridView.SelectionChanged += OrderDataGridView_SelectionChanged;
        }


        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet2.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter1.Fill(this.flower_databaseDataSet2.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet.Composition". При необходимости она может быть перемещена или удалена.
            //    this.compositionTableAdapter1.Fill(this.flower_databaseDataSet2.Composition);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet.Order". При необходимости она может быть перемещена или удалена.
            // this.orderTableAdapter.Fill(this.flower_databaseDataSet.Order);

            OrderDataGridView.SelectionChanged += OrderDataGridView_SelectionChanged;

            OrderDataGridView.Columns["idorderDataGridViewTextBoxColumn"].HeaderText = "Номер заказа";
            OrderDataGridView.Columns["dataoforderDataGridViewTextBoxColumn"].HeaderText = "Дата доставки";
            OrderDataGridView.Columns["idcustomerDataGridViewTextBoxColumn"].HeaderText = "Идентификатор пользователя";
            OrderDataGridView.Columns["timeofdeliveryDataGridViewTextBoxColumn"].HeaderText = "Время доставки";
            OrderDataGridView.Columns["id_composition"].HeaderText = "Номер позиции";
        }



        private void OpenAddOrderButton_Click(object sender, EventArgs e)
        {
            AddOrderPanel.Visible = true;
        }

        private void OpenChangeOrderButton_Click(object sender, EventArgs e)
        {
            ChangeOrderInfoPanel.Visible = true;
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                int orderId = (int)OrderDataGridView.SelectedRows[0].Cells["idorderDataGridViewTextBoxColumn"].Value;

                Database database = new Database();
                database.openConnection();

                try
                {
                    //    string deleteComponentCompositionQuery = "DELETE FROM [dbo].[Component - composition] WHERE [id_bouquet] IN (SELECT [id_bouquet] FROM [dbo].[Composition] WHERE [id_order] = @id_order)";
                    //    SqlCommand deleteComponentCompositionCommand = new SqlCommand(deleteComponentCompositionQuery, database.getConnection());
                    //    deleteComponentCompositionCommand.Parameters.AddWithValue("@id_order", orderId);
                    //    deleteComponentCompositionCommand.ExecuteNonQuery();

                    //    string deleteCompositionQuery = "DELETE FROM [dbo].[Composition] WHERE [id_order] = @id_order";
                    //    SqlCommand deleteCompositionCommand = new SqlCommand(deleteCompositionQuery, database.getConnection());
                    //    deleteCompositionCommand.Parameters.AddWithValue("@id_order", orderId);
                    //    deleteCompositionCommand.ExecuteNonQuery();
                    //
                    string deleteOrderQuery = "DELETE FROM [dbo].[Order] WHERE [id_order] = @id_order";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, database.getConnection());
                    deleteOrderCommand.Parameters.AddWithValue("@id_order", orderId);
                    deleteOrderCommand.ExecuteNonQuery();

                    this.orderTableAdapter1.Fill(this.flower_databaseDataSet2.Order);

                    MessageBox.Show("Заказ успешно удален");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                database.closeConnection();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заказ для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerIDTextBox.Text) ||
   string.IsNullOrWhiteSpace(PositionIDTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime date = AddOrderDatePicker.Value;
            int customerId = int.Parse(CustomerIDTextBox.Text);
            string time = TimeOfDeliveryTextBox.Text;
            int positionId = int.Parse(PositionIDTextBox.Text);

            Database database = new Database();
            database.openConnection();

            string addOrderQuery = "INSERT INTO [dbo].[Order] ([data_of_order], [id_customer], [time_of_delivery], [id_composition]) " +
                   "VALUES (@date, @customerId, @time, @positionId)";

            SqlCommand insertClientCommand = new SqlCommand(addOrderQuery, database.getConnection());
            insertClientCommand.Parameters.AddWithValue("@date", date);
            insertClientCommand.Parameters.AddWithValue("@customerId", customerId);
            insertClientCommand.Parameters.AddWithValue("@time", time);
            insertClientCommand.Parameters.AddWithValue("@positionId", positionId);

            try
            {
                insertClientCommand.ExecuteNonQuery();

                this.orderTableAdapter1.Fill(this.flower_databaseDataSet2.Order);

                MessageBox.Show("Заказ успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CustomerIDTextBox.Clear();
            TimeOfDeliveryTextBox.Clear();
            PositionIDTextBox.Clear();

            database.closeConnection();
        }

        private void OrderDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = OrderDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = OrderDataGridView.Rows[rowIndex];

                OrderIDTextBox.Text = selectedRow.Cells["idorderDataGridViewTextBoxColumn"].Value.ToString();
                CustomerIDChange.Text = selectedRow.Cells["idcustomerDataGridViewTextBoxColumn"].Value.ToString();
                PositionIDChange.Text = selectedRow.Cells["id_composition"].Value.ToString();
                ChangeOrderDatePicker.Value = (DateTime)selectedRow.Cells["dataoforderDataGridViewTextBoxColumn"].Value;
                TimeOfDeliveryChange.Text = selectedRow.Cells["timeofdeliveryDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void ChangeOrderInfoButton_Click(object sender, EventArgs e)
        {
            if (OrderDataGridView.SelectedRows.Count > 0)
            {
                int orderId = (int)OrderDataGridView.SelectedRows[0].Cells[0].Value;

                int newCustomerId = int.Parse(CustomerIDChange.Text);
                int newPositionId = int.Parse(PositionIDChange.Text);
                DateTime newDate = ChangeOrderDatePicker.Value;
                string newTime = TimeOfDeliveryChange.Text;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string updateOrderQuery = "UPDATE [dbo].[Order] SET [data_of_order] = @data_of_order, [id_customer] = @id_customer, [time_of_delivery] = @time_of_delivery, [id_composition] = @id_position WHERE [id_order] = @id_order";
                    SqlCommand updateCommand = new SqlCommand(updateOrderQuery, database.getConnection());
                    updateCommand.Parameters.AddWithValue("@id_customer", newCustomerId);
                    updateCommand.Parameters.AddWithValue("@id_order", orderId);
                    updateCommand.Parameters.AddWithValue("@data_of_order", newDate);
                    updateCommand.Parameters.AddWithValue("@time_of_delivery", newTime);
                    updateCommand.Parameters.AddWithValue("@id_position", newPositionId);

                    updateCommand.ExecuteNonQuery();

                    this.orderTableAdapter1.Fill(this.flower_databaseDataSet2.Order);

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
                MessageBox.Show("Пожалуйста, выберите заказ для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackToAdminMenuButton_Click(object sender, EventArgs e)
        {
            AdministratorForm administatorForm = new AdministratorForm();
            administatorForm.Show();
            this.Hide();
        }

        private void OrderSearchButton_Click(object sender, EventArgs e)
        {
            string selectedColumnName = SearchComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedColumnName))
            {
                MessageBox.Show("Пожалуйста, выберите столбец для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string systemColumnName = columnMappings[selectedColumnName];

            string searchText = SearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Пожалуйста, введите текст для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchQuery = $"SELECT * FROM [dbo].[Order] WHERE [{systemColumnName}] = @searchText";

            Database database = new Database();
            database.openConnection();

            try
            {
                SqlCommand searchCommand = new SqlCommand(searchQuery, database.getConnection());
                searchCommand.Parameters.AddWithValue("@searchText", searchText);

                SqlDataAdapter adapter = new SqlDataAdapter(searchCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                OrderDataGridView.DataSource = dataTable;

                MessageBox.Show("Поиск завершен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении поиска: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            database.closeConnection();
        }

        private void OpenOrderSearchButton_Click(object sender, EventArgs e)
        {
            OrderSearchPanel.Visible = true;
        }

        private void LoadColumnNamesToComboBox()
        {
            SearchComboBox.Items.Add("Номер заказа");
            SearchComboBox.Items.Add("Дата доставки");
            SearchComboBox.Items.Add("Идентификатор пользователя");
            SearchComboBox.Items.Add("Время доставки");
            SearchComboBox.Items.Add("Номер позиции");
        }

    }
}
