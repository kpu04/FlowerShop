using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerCourse
{
    public partial class CompositionForm : Form
    {
        private Dictionary<string, string> columnMappings = new Dictionary<string, string>()
{
    { "Номер букета", "id_bouquet" },
    { "Дата сборки", "making_date" },
    { "Схема сборки", "bouquet_scheme" },
    { "Название букета", "bouquet's_name" },
    { "Стоимость", "price" },
    { "Категория", "category" },
    { "Фото", "photo" }
};

        public CompositionForm()
        {
            InitializeComponent();

         //   LoadColumnNamesToComboBox();

            AddPanel.Visible = false;
            ChangePanel.Visible = false;
            ChangePhotoPanel.Visible = false;
            SearchPanel.Visible = false;

            CompositionDataGridView.SelectionChanged += CompositionDataGridView_SelectionChanged;

        }

        private void CompositionForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet3.Composition". При необходимости она может быть перемещена или удалена.
            this.compositionTableAdapter2.Fill(this.flower_databaseDataSet3.Composition);
            SearchWhatComboBox.Items.AddRange(columnMappings.Keys.ToArray());

            // TODO: данная строка кода позволяет загрузить данные в таблицу "flower_databaseDataSet1.Composition". При необходимости она может быть перемещена или удалена.
      //      this.compositionTableAdapter1.Fill(this.flower_databaseDataSet1.Composition);

            //  SearchWhatComboBox.Items.AddRange(columnMappings.Keys.ToArray());

            CompositionDataGridView.Columns["idbouquetDataGridViewTextBoxColumn"].HeaderText = "Номер букета";
            CompositionDataGridView.Columns["makingdateDataGridViewTextBoxColumn"].HeaderText = "Дата сборки";
            CompositionDataGridView.Columns["bouquetschemeDataGridViewTextBoxColumn"].HeaderText = "Схема сборки";
            CompositionDataGridView.Columns["bouquetsnameDataGridViewTextBoxColumn"].HeaderText = "Название букета";
            CompositionDataGridView.Columns["priceDataGridViewTextBoxColumn"].HeaderText = "Стоимость";
            CompositionDataGridView.Columns["categoryDataGridViewTextBoxColumn"].HeaderText = "Категория";
            CompositionDataGridView.Columns["photo"].HeaderText = "Фото";

            CompositionDataGridView.SelectionChanged += CompositionDataGridView_SelectionChanged;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Отображение выбранного изображения в PictureBox
                imagePictureBox.Image = Image.FromFile(openFileDialog.FileName);

                // Запись пути к изображению в текстовое поле
                imagePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imagePathTextBox.Text))
            {
                MessageBox.Show("Выберите изображение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idComposition;
            if (!int.TryParse(idCompositionTextBox.Text, out idComposition))
            {
                MessageBox.Show("Введите корректный ID композиции.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string imagePath = imagePathTextBox.Text;
            if (!File.Exists(imagePath))
            {
                MessageBox.Show("Указанный файл не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imageBytes;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                imagePictureBox.Image.Save(memoryStream, imagePictureBox.Image.RawFormat);
                imageBytes = memoryStream.ToArray();
            }

            Database database = new Database();
            database.openConnection();
            string query = "UPDATE [dbo].[Composition] SET [photo] = @Photo WHERE [id_bouquet] = @IdComposition";

            SqlCommand updateCommand = new SqlCommand(query, database.getConnection());

            updateCommand.Parameters.AddWithValue("@Photo", imageBytes);
            updateCommand.Parameters.AddWithValue("@IdComposition", idComposition);

            int rowsAffected = updateCommand.ExecuteNonQuery();
            this.compositionTableAdapter2.Fill(this.flower_databaseDataSet3.Composition);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Изображение успешно добавлено в базу данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Композиция с указанным ID не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            database.closeConnection();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdministratorForm administrator = new AdministratorForm();
            administrator.Show();
            this.Hide();
        }

        private void OpenAddPanel_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
        }

        private void OpenChangePanel_Click(object sender, EventArgs e)
        {
            ChangePanel.Visible = true;
        }

        private void OpenSearchButton_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = true;
        }

        private void OpenPhotoButton_Click(object sender, EventArgs e)
        {
            ChangePhotoPanel.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CompositionDataGridView.SelectedRows.Count > 0)
            {
                int bouquetID = (int)CompositionDataGridView.SelectedRows[0].Cells["idbouquetDataGridViewTextBoxColumn"].Value;

                Database database = new Database();
                database.openConnection();

                try
                {
                    string deleteCompositionQuery = "DELETE FROM [dbo].[Composition] WHERE [id_bouquet] = @id_bouquet";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteCompositionQuery, database.getConnection());
                    deleteOrderCommand.Parameters.AddWithValue("@id_bouquet", bouquetID);
                    deleteOrderCommand.ExecuteNonQuery();

                    this.compositionTableAdapter2.Fill(this.flower_databaseDataSet3.Composition);

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddDatePicker.Text) ||
  string.IsNullOrWhiteSpace(AddCategoryComboBox.Text) || string.IsNullOrWhiteSpace(AddNameTextBox.Text) || string.IsNullOrWhiteSpace(AddSchemeTextBox.Text)
  || string.IsNullOrWhiteSpace(AddPriceTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime date = AddDatePicker.Value;
            int scheme = int.Parse(AddSchemeTextBox.Text);
            string category = AddCategoryComboBox.Text;
            string name = AddNameTextBox.Text;
            decimal price = decimal.Parse(AddPriceTextBox.Text);

            Database database = new Database();
            database.openConnection();

            string addComponentQuery = "INSERT INTO [dbo].[Composition] ([making_date], [bouquet_scheme], [bouquet's_name], [price], [category], [photo]) " +
                   "VALUES (@date, @scheme, @name, @price, @category, NULL)";



            SqlCommand insertClientCommand = new SqlCommand(addComponentQuery, database.getConnection());
            insertClientCommand.Parameters.AddWithValue("@date", date);
            insertClientCommand.Parameters.AddWithValue("@scheme", scheme);
            insertClientCommand.Parameters.AddWithValue("@name", name);
            insertClientCommand.Parameters.AddWithValue("@priceValue", price);
            insertClientCommand.Parameters.AddWithValue("@category", category);
            insertClientCommand.Parameters.AddWithValue("@price", price);

            try
            {
                insertClientCommand.ExecuteNonQuery();

                this.compositionTableAdapter2.Fill(this.flower_databaseDataSet3.Composition);

                MessageBox.Show("Композиция успешно добавлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении композиции: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AddSchemeTextBox.Clear();
            AddNameTextBox.Clear();
            AddPriceTextBox.Clear();
            AddSchemeTextBox.Clear();

            database.closeConnection();
        }

        private void CompositionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CompositionDataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = CompositionDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = CompositionDataGridView.Rows[rowIndex];

                ChangeDatePicker.Value = (DateTime)selectedRow.Cells["makingdateDataGridViewTextBoxColumn"].Value;
                ChangeCategoryComboBox.Text = selectedRow.Cells["categoryDataGridViewTextBoxColumn"].Value.ToString();
                ChangeNameTextBox.Text = selectedRow.Cells["bouquetsnameDataGridViewTextBoxColumn"].Value.ToString();
                ChangePriceTextBox.Text = selectedRow.Cells["priceDataGridViewTextBoxColumn"].Value.ToString();
                ChangeSchemeTextBox.Text = selectedRow.Cells["bouquetschemeDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (CompositionDataGridView.SelectedRows.Count > 0)
            {
                int bouquetID = (int)CompositionDataGridView.SelectedRows[0].Cells["idbouquetDataGridViewTextBoxColumn"].Value;

                DateTime date = ChangeDatePicker.Value;
                int scheme = int.Parse(ChangeSchemeTextBox.Text);
                string category = ChangeCategoryComboBox.Text;
                string name = ChangeNameTextBox.Text;
                decimal price = decimal.Parse(ChangePriceTextBox.Text);

                Database database = new Database();
                database.openConnection();

                try
                {
                    string updateOrderQuery = "UPDATE [dbo].[Composition] SET [making_date] = @date, [bouquet_scheme] = @scheme, [bouquet's_name] = @name, [price] = @price, [category] = @category WHERE [id_bouquet] = @id_bouquet";
                    SqlCommand updateCommand = new SqlCommand(updateOrderQuery, database.getConnection());
                    updateCommand.Parameters.AddWithValue("@date", date);
                    updateCommand.Parameters.AddWithValue("@scheme", scheme);
                    updateCommand.Parameters.AddWithValue("@category", category);
                    updateCommand.Parameters.AddWithValue("@name", name);
                    updateCommand.Parameters.AddWithValue("@price", price);
                    updateCommand.Parameters.AddWithValue("@id_bouquet", bouquetID);

                    updateCommand.ExecuteNonQuery();

                    this.compositionTableAdapter2.Fill(this.flower_databaseDataSet3.Composition);

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
                MessageBox.Show("Пожалуйста, выберите композицию для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string selectedColumnName = SearchWhatComboBox.SelectedItem?.ToString();

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

            string searchQuery = $"SELECT * FROM [dbo].[Composition] WHERE [{systemColumnName}] = @searchText";

            Database database = new Database();
            database.openConnection();

            try
            {
                SqlCommand searchCommand = new SqlCommand(searchQuery, database.getConnection());
                searchCommand.Parameters.AddWithValue("@searchText", searchText);

                SqlDataAdapter adapter = new SqlDataAdapter(searchCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                CompositionDataGridView.DataSource = dataTable;

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

