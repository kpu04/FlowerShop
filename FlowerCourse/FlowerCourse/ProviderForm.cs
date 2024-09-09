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
    public partial class ProviderForm : Form
    {
        public ProviderForm()
        {
            InitializeComponent();

            AddPanel.Visible = false;
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.flower_databaseDataSet.Provider);

            ProviderDataGridView.Columns["idproviderDataGridViewTextBoxColumn"].HeaderText = "Номер поставщика";
            ProviderDataGridView.Columns["townDataGridViewTextBoxColumn"].HeaderText = "Город";
            ProviderDataGridView.Columns["phnumDataGridViewTextBoxColumn"].HeaderText = "Номер телефона";
            ProviderDataGridView.Columns["idshipmentDataGridViewTextBoxColumn"].HeaderText = "Номер поставки";
        }

        private void OpenAddButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible=true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProviderDataGridView.SelectedRows.Count > 0)
            {
                int provId = (int)ProviderDataGridView.SelectedRows[0].Cells["idproviderDataGridViewTextBoxColumn"].Value;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string deleteOrderQuery = "DELETE FROM [dbo].[Provider] WHERE [id_provider] = @provId";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, database.getConnection());
                    deleteOrderCommand.Parameters.AddWithValue("@provId", provId);
                    deleteOrderCommand.ExecuteNonQuery();

                    this.providerTableAdapter.Fill(this.flower_databaseDataSet.Provider);

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
            if (string.IsNullOrWhiteSpace(AddTown.Text) ||
 string.IsNullOrWhiteSpace(AddPhone.Text) || string.IsNullOrWhiteSpace(AddShipment.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string town = AddTown.Text;
            string phone = AddPhone.Text;
            string shipment = AddShipment.Text;
            ;
            Database database = new Database();
            database.openConnection();

            string addProviderQuery = "INSERT INTO [dbo].[Provider] ([town], [ph_num], [id_shipment]) " +
                   "VALUES (@town, @phone, @id_shipment)";

            SqlCommand insertClientCommand = new SqlCommand(addProviderQuery, database.getConnection());
            insertClientCommand.Parameters.AddWithValue("@town", town);
            insertClientCommand.Parameters.AddWithValue("@phone", phone);
            insertClientCommand.Parameters.AddWithValue("@id_shipment", shipment);


            try
            {
                insertClientCommand.ExecuteNonQuery();

                this.providerTableAdapter.Fill(this.flower_databaseDataSet.Provider);

                MessageBox.Show("Поставщик успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении поставщика: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AddTown.Clear();
            AddShipment.Clear();
            AddPhone.Clear();

            database.closeConnection();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ComponentForm component = new ComponentForm();
            component.Show();
            this.Hide();
        }
    }
}
