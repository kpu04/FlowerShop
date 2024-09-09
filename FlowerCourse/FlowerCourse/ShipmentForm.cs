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
    public partial class ShipmentForm : Form
    {
        public ShipmentForm()
        {
            InitializeComponent();

            AddPanel.Visible = false;
        }

        private void ShipmentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet.Shipment". При необходимости она может быть перемещена или удалена.
            this.shipmentTableAdapter.Fill(this.flower_databaseDataSet.Shipment);

            ShipmentDataGridView.Columns["idshipmentDataGridViewTextBoxColumn"].HeaderText = "Номер поставки";
            ShipmentDataGridView.Columns["dateofshipmentDataGridViewTextBoxColumn"].HeaderText = "Дата поставки";
            ShipmentDataGridView.Columns["idproviderDataGridViewTextBoxColumn"].HeaderText = "Номер поставщика";
        }

        private void OpenAddShipment_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
        }

        private void DeleteShipment_Click(object sender, EventArgs e)
        {
            if (ShipmentDataGridView.SelectedRows.Count > 0)
            {
                int shipId = (int)ShipmentDataGridView.SelectedRows[0].Cells["idshipmentDataGridViewTextBoxColumn"].Value;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string deleteOrderQuery = "DELETE FROM [dbo].[Shipment] WHERE [id_shipment] = @shipId";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, database.getConnection());
                    deleteOrderCommand.Parameters.AddWithValue("@shipId", shipId);
                    deleteOrderCommand.ExecuteNonQuery();

                    this.shipmentTableAdapter.Fill(this.flower_databaseDataSet.Shipment);

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
            ComponentForm component = new ComponentForm();
            component.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddDatePicker.Text) ||
  string.IsNullOrWhiteSpace(AddIDProvTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime date = AddDatePicker.Value;
            int providerID = int.Parse(AddIDProvTextBox.Text);
;
            Database database = new Database();
            database.openConnection();

            string addShipmentQuery = "INSERT INTO [dbo].[Shipment] ([date_of_shipment], [id_provider]) " +
                   "VALUES (@date, @providerID)";

            SqlCommand insertClientCommand = new SqlCommand(addShipmentQuery, database.getConnection());
            insertClientCommand.Parameters.AddWithValue("@date", date);
            insertClientCommand.Parameters.AddWithValue("@providerID", providerID);


            try
            {
                insertClientCommand.ExecuteNonQuery();

                this.shipmentTableAdapter.Fill(this.flower_databaseDataSet.Shipment);

                MessageBox.Show("Поставка успешно добавлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении поставки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AddIDProvTextBox.Clear();

            database.closeConnection();
        }
    }
}
