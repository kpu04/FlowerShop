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
    public partial class ComponentInfoForm : Form
    {
        private Dictionary<string, string> columnMappings = new Dictionary<string, string>()
        {
            { "Номер компонента", "id_component" },
            { "Название компонента", "name" },
            { "Срок хранения", "shelf_life" },
            { "Условия хранения", "storage_conditions" },
            { "Количество", "quantity" },
            { "Сорт", "sort" }
        };
        public ComponentInfoForm()
        {
            InitializeComponent();

            AddPanel.Visible = false;
            ChangePanel.Visible = false;
            SearchPanel.Visible = false;

            ComponentDataGridView.SelectionChanged += ComponentDataGridView_SelectionChanged;
        }

        private void ComponentInfoForm_Load(object sender, EventArgs e)
        {
            SearchComboBox.Items.AddRange(columnMappings.Keys.ToArray());

            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet.Component". При необходимости она может быть перемещена или удалена.
            this.componentTableAdapter.Fill(this.flower_databaseDataSet.Component);

            ComponentDataGridView.Columns["idcomponentDataGridViewTextBoxColumn"].HeaderText = "Номер компонента";
            ComponentDataGridView.Columns["nameDataGridViewTextBoxColumn"].HeaderText = "Название компонента";
            ComponentDataGridView.Columns["shelflifeDataGridViewTextBoxColumn"].HeaderText = "Срок хранения";
            ComponentDataGridView.Columns["storageconditionsDataGridViewTextBoxColumn"].HeaderText = "Условия хранения";
            ComponentDataGridView.Columns["quantityDataGridViewTextBoxColumn"].HeaderText = "Количество";
            ComponentDataGridView.Columns["sortDataGridViewTextBoxColumn"].HeaderText = "Сорт";

            ComponentDataGridView.SelectionChanged += ComponentDataGridView_SelectionChanged;
        }

        private void ComponentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ComponentDataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = ComponentDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = ComponentDataGridView.Rows[rowIndex];

                ChangeCompIDTextBox.Text = selectedRow.Cells["idcomponentDataGridViewTextBoxColumn"].Value.ToString();
                ChangeNameTextBox.Text = selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
                ChangeStorageTextBox.Text = selectedRow.Cells["storageconditionsDataGridViewTextBoxColumn"].Value.ToString();
                ChangeDatePicker.Value = (DateTime)selectedRow.Cells["shelflifeDataGridViewTextBoxColumn"].Value;
                ChangeSortTextBox.Text = selectedRow.Cells["sortDataGridViewTextBoxColumn"].Value.ToString();
                ChangeQuantityTextBox.Text = selectedRow.Cells["quantityDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void OpenAddPanel_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
        }

        private void OpenChangeButton_Click(object sender, EventArgs e)
        {
            ChangePanel.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ComponentDataGridView.SelectedRows.Count > 0)
            {
                int compId = (int)ComponentDataGridView.SelectedRows[0].Cells["idcomponentDataGridViewTextBoxColumn"].Value;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string deleteComponentCompositionQuery = "DELETE FROM [dbo].[Component - composition] WHERE [id_component] = @id_component";
                    SqlCommand deleteComponentCompositionCommand = new SqlCommand(deleteComponentCompositionQuery, database.getConnection());
                    deleteComponentCompositionCommand.Parameters.AddWithValue("@id_component", compId);
                    deleteComponentCompositionCommand.ExecuteNonQuery();


                    string deleteComponentQuery = "DELETE FROM [dbo].[Component] WHERE [id_component] = @id_component";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteComponentQuery, database.getConnection());
                    deleteOrderCommand.Parameters.AddWithValue("@id_component", compId);
                    deleteOrderCommand.ExecuteNonQuery();

                    this.componentTableAdapter.Fill(this.flower_databaseDataSet.Component);

                    MessageBox.Show("Компонент успешно удален");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении компонента: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SearchPanel.Visible = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdministratorForm admin = new AdministratorForm();
            admin.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddShelfDatePicker.Text) ||
                string.IsNullOrWhiteSpace(AddStorageTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddQuantityTextBox.Text) ||
                string.IsNullOrWhiteSpace(AddSort.Text)
               )
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime date = AddShelfDatePicker.Value;
            int quantity = int.Parse(AddQuantityTextBox.Text);
            string name = AddNameTextBox.Text;
            string storage = AddStorageTextBox.Text;
            string sort = AddSort.Text;

            Database database = new Database();
            database.openConnection();

            string addComponentQuery = "INSERT INTO [dbo].[Component] ([name], [shelf_life], [storage_conditions], [quantity], [sort]) " +
                   "VALUES (@name, @date, @storage, @quantity, @sort)";

            SqlCommand insertClientCommand = new SqlCommand(addComponentQuery, database.getConnection());
            insertClientCommand.Parameters.AddWithValue("@date", date);
            insertClientCommand.Parameters.AddWithValue("@name", name);
            insertClientCommand.Parameters.AddWithValue("@quantity", quantity);
            insertClientCommand.Parameters.AddWithValue("@sort", sort);
            insertClientCommand.Parameters.AddWithValue("@storage", storage);

            try
            {
                insertClientCommand.ExecuteNonQuery();

                this.componentTableAdapter.Fill(this.flower_databaseDataSet.Component);

                MessageBox.Show("Компонент успешно добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении компонента: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AddQuantityTextBox.Clear();
            AddNameTextBox.Clear();
            AddStorageTextBox.Clear();
            AddSort.Clear();

            database.closeConnection();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ComponentDataGridView.SelectedRows.Count > 0)
            {
                int compID = (int)ComponentDataGridView.SelectedRows[0].Cells[0].Value;

                DateTime date = ChangeDatePicker.Value;
                int quantity = int.Parse(ChangeQuantityTextBox.Text);
                string name = ChangeNameTextBox.Text;
                string storage = ChangeStorageTextBox.Text;
                string sort = ChangeSortTextBox.Text;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string updateComponentQuery = "UPDATE [dbo].[Component] SET [name] = @name, [shelf_life] = @date, [storage_conditions] = @storage, [quantity] = @quantity, [sort] = @sort WHERE [id_component] = @compID";
                    SqlCommand updateCommand = new SqlCommand(updateComponentQuery, database.getConnection());
                    updateCommand.Parameters.AddWithValue("@name", name);
                    updateCommand.Parameters.AddWithValue("@date", date);
                    updateCommand.Parameters.AddWithValue("@storage", storage);
                    updateCommand.Parameters.AddWithValue("@sort", sort);
                    updateCommand.Parameters.AddWithValue("@quantity", quantity);
                    updateCommand.Parameters.AddWithValue("@compID", compID);
                 
                    updateCommand.ExecuteNonQuery();

                    this.componentTableAdapter.Fill(this.flower_databaseDataSet.Component);

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

        private void SearchButton_Click(object sender, EventArgs e)
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

            string searchQuery = $"SELECT * FROM [dbo].[Component] WHERE [{systemColumnName}] = @searchText";

            Database database = new Database();
            database.openConnection();

            try
            {
                SqlCommand searchCommand = new SqlCommand(searchQuery, database.getConnection());
                searchCommand.Parameters.AddWithValue("@searchText", searchText);

                SqlDataAdapter adapter = new SqlDataAdapter(searchCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                ComponentDataGridView.DataSource = dataTable;

                MessageBox.Show("Поиск завершен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении поиска: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            database.closeConnection();
        }
    }
}
