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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FlowerCourse
{
    public partial class MyOrder : Form
    {
        private int idCustomer;
        private int userId;

        public MyOrder(int idCustomer)
        {
            InitializeComponent();
            this.idCustomer = idCustomer;
            FillMyOrdersDataGridView();
        }
        
        private void FillMyOrdersDataGridView()
        {
            Database database = new Database();
            try
            {
                database.openConnection();

                string query = @"SELECT C.photo, C.[bouquet's_name], C.price, C.category, O.data_of_order, O.time_of_delivery
                 FROM [dbo].[Composition] C
                 INNER JOIN [dbo].[Order] O ON C.id_bouquet = O.id_composition
                 WHERE O.id_customer = @idCustomer";

                SqlCommand command = new SqlCommand(query, database.getConnection());
                command.Parameters.AddWithValue("@idCustomer", idCustomer);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Создаем словарь для сохранения системных и пользовательских названий колонок
                    Dictionary<string, string> columnNames = new Dictionary<string, string>()
            {
                { "photo", "Фото" },
                { "bouquet's_name", "Название букета" },
                { "price", "Цена" },
                { "category", "Категория" },
                { "data_of_order", "Дата доставки" },
                { "time_of_delivery", "Время доставки" }
            };

                    // Переименовываем колонки в основной таблице и добавляем колонку "Статус"
                    foreach (var pair in columnNames)
                    {
                        table.Columns[pair.Key].ColumnName = pair.Value;
                    }
                    table.Columns.Add("Статус", typeof(string));

                    // Заполнение колонки "Статус"
                    foreach (DataRow row in table.Rows)
                    {
                        DateTime dataOfOrder = Convert.ToDateTime(row["Дата доставки"]);
                        TimeSpan timeOfDelivery = (TimeSpan)row["Время доставки"];
                        DateTime deliveryDateTime = dataOfOrder.Add(timeOfDelivery);
                        DateTime currentDateTime = DateTime.Now;

                        string status = (currentDateTime > deliveryDateTime) ? "Выполнен" : "Ожидается";

                        row["Статус"] = status;
                    }

                    // Устанавливаем источник данных для DataGridView
                    MyOrderDataGridView.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void GenerateReceiptAsPDF()
        {
            if (MyOrderDataGridView.SelectedRows.Count > 0)
            {
                string bouquetName = MyOrderDataGridView.SelectedRows[0].Cells["Название букета"].Value.ToString();
                string price = MyOrderDataGridView.SelectedRows[0].Cells["Цена"].Value.ToString();

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF файл (*.pdf)|*.pdf";
                saveDialog.Title = "Выберите место для сохранения файла";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));

                    doc.Open();

                    Paragraph header = new Paragraph();
                    header.Alignment = Element.ALIGN_CENTER;

                    BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", "Cp1251", BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font russianFont = new iTextSharp.text.Font(baseFont, 12);

                    header.Add(new Phrase("ООО \"P&PFlowers\"\n", russianFont));
                    header.Add(new Phrase("г. Могилёв, пр-т Димитрова 64\n", russianFont));
                    header.Add(new Phrase("Режим работы: круглосуточно\n", russianFont));
                    header.Add(new Phrase("СПАСИБО ЗА ПОКУПКУ!\n", russianFont));
                    header.Add(new Phrase("ЖДЕМ ВАС СНОВА!", russianFont));
                    doc.Add(header);

                    doc.Add(new Phrase(" ", russianFont));

                    Paragraph title = new Paragraph("Товарный чек", russianFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 5f;
                    doc.Add(title);

                    Paragraph bouquetPara = new Paragraph("Название букета: " + bouquetName, russianFont);
                    bouquetPara.Alignment = Element.ALIGN_CENTER;
                    doc.Add(bouquetPara);

                    Paragraph pricePara = new Paragraph("Цена: " + price, russianFont);
                    pricePara.Alignment = Element.ALIGN_CENTER;
                    doc.Add(pricePara);

                    Paragraph signature = new Paragraph("Подпись: P&P", russianFont);
                    signature.Alignment = Element.ALIGN_CENTER;
                    doc.Add(signature);

                    DateTime dateOfOrder = Convert.ToDateTime(MyOrderDataGridView.SelectedRows[0].Cells["Дата доставки"].Value);
                    string formattedDate = dateOfOrder.ToString("dd.MM.yyyy");

                    Paragraph datePara = new Paragraph("Дата: " + formattedDate, russianFont);
                    datePara.Alignment = Element.ALIGN_CENTER;
                    datePara.SpacingAfter = 10f;
                    doc.Add(datePara);

                    string imagePath = @"C:\Users\kuren\Downloads\image049-21.jpg";
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);
                    image.ScaleToFit(100f, 100f);
                    image.Alignment = Element.ALIGN_CENTER;
                    doc.Add(image);



                    doc.Close();
                    writer.Close();
                                    MessageBox.Show("Отчет успешно создан и сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(saveDialog.FileName);
                }
            }
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            if (MyOrderDataGridView.SelectedRows.Count > 0)
            {
                DateTime dataOfOrder = Convert.ToDateTime(MyOrderDataGridView.SelectedRows[0].Cells["Дата доставки"].Value);
                TimeSpan timeOfDelivery = (TimeSpan)MyOrderDataGridView.SelectedRows[0].Cells["Время доставки"].Value;

                int orderId = GetOrderId(idCustomer, dataOfOrder, timeOfDelivery);

                DateTime deliveryDateTime = dataOfOrder.Add(timeOfDelivery);
                if (DateTime.Now >= deliveryDateTime)
                {
                    MessageBox.Show("Вы не можете удалить этот заказ, так как он уже выполнен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DateTime.Now >= deliveryDateTime.AddHours(-3))
                {
                    MessageBox.Show("Вы не можете удалить этот заказ, так как осталось менее 3 часов до доставки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    database.openConnection();

                    string deleteQuery = "DELETE FROM [dbo].[Order] WHERE id_order = @orderId";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, database.getConnection());
                    deleteCommand.Parameters.AddWithValue("@orderId", orderId);
                    deleteCommand.ExecuteNonQuery();
                    MyOrderDataGridView.Rows.RemoveAt(MyOrderDataGridView.SelectedRows[0].Index);
                    MessageBox.Show("Заказ успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillMyOrdersDataGridView(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заказ для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetOrderId(int customerId, DateTime dataOfOrder, TimeSpan timeOfDelivery)
        {
            Database database = new Database();
            int orderId = 0;
            try
            {
                database.openConnection();

                string query = @"SELECT id_order
                         FROM [dbo].[Order]
                         WHERE id_customer = @customerId AND data_of_order = @dataOfOrder AND time_of_delivery = @timeOfDelivery";

                SqlCommand command = new SqlCommand(query, database.getConnection());
                command.Parameters.AddWithValue("@customerId", customerId);
                command.Parameters.AddWithValue("@dataOfOrder", dataOfOrder);
                command.Parameters.AddWithValue("@timeOfDelivery", timeOfDelivery);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    orderId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении id заказа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }

            return orderId;
        }

        private void MakePar_Click(object sender, EventArgs e)
        {
            GenerateReceiptAsPDF();
        }
    }
}
