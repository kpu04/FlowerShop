using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void MakeRep_Click(object sender, EventArgs e)
        {
            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font russianFont = new iTextSharp.text.Font(baseFont, 12);

            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Дата начала не может быть позже даты окончания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"SELECT O.id_order AS 'Номер заказа', C.[bouquet's_name] AS 'Название букета', 
         CONVERT(varchar, O.data_of_order, 104) AS 'Дата доставки', 
         C.category AS 'Категория', C.price AS 'Цена'
         FROM [dbo].[Order] O
         INNER JOIN [dbo].[Composition] C ON O.id_composition = C.id_bouquet
         WHERE O.data_of_order BETWEEN @startDate AND @endDate";

            DataTable table = new DataTable();
            Database database = new Database();
            database.openConnection();

            using (SqlCommand command = new SqlCommand(query, database.getConnection()))
            {
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                try
                {
                    database.openConnection();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при получении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.closeConnection();
                }
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF файл (*.pdf)|*.pdf";
            saveDialog.Title = "Выберите место для сохранения файла";


            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));

                doc.Open();

                Paragraph reportHeader = new Paragraph();
                reportHeader.Alignment = Element.ALIGN_CENTER;
                reportHeader.Add(new Phrase($"Отчёт о продажах компании P&PFlowers за период ({startDate.ToString("dd.MM.yyyy")} - {endDate.ToString("dd.MM.yyyy")})", russianFont));
                reportHeader.SpacingAfter = 10f;

                doc.Add(reportHeader);

                PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
                pdfTable.WidthPercentage = 100;
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.DefaultCell.BorderWidth = 1;

                foreach (DataColumn column in table.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, russianFont));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                foreach (DataRow row in table.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), russianFont));
                        pdfTable.AddCell(cell);
                    }
                }

                doc.Add(pdfTable);
                Paragraph currentDatePara = new Paragraph();
                currentDatePara.Alignment = Element.ALIGN_CENTER;
                currentDatePara.Add(new Phrase($"{DateTime.Now.ToString("dd.MM.yyyy")}", russianFont));
                currentDatePara.SpacingBefore = 10f;
                doc.Add(currentDatePara);

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

        private void MakeStat_Click(object sender, EventArgs e)
        {
            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font russianFont = new iTextSharp.text.Font(baseFont, 12);

            string query = @"SELECT C.[bouquet's_name] AS 'Название букета', 
                     C.price AS 'Цена',
                     COUNT(O.id_order) AS 'Количество проданных букетов'
                     FROM [dbo].[Composition] C
                     LEFT JOIN [dbo].[Order] O ON C.id_bouquet = O.id_composition
                     GROUP BY C.[bouquet's_name], C.price
                     ORDER BY COUNT(O.id_order) DESC";

            DataTable table = new DataTable();
            Database database = new Database();
            database.openConnection();

            using (SqlCommand command = new SqlCommand(query, database.getConnection()))
            {
                try
                {
                    database.openConnection();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при получении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.closeConnection();
                }
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF файл (*.pdf)|*.pdf";
            saveDialog.Title = "Выберите место для сохранения файла";


            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveDialog.FileName, FileMode.Create));

                doc.Open();

                Paragraph reportHeader = new Paragraph();
                reportHeader.Alignment = Element.ALIGN_CENTER;
                reportHeader.Add(new Phrase($"Статистика продаж букетов компании P&PFlowers ", russianFont));
                reportHeader.SpacingAfter = 10f;

                doc.Add(reportHeader);

                PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
                pdfTable.WidthPercentage = 100;
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.DefaultCell.BorderWidth = 1;

                foreach (DataColumn column in table.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, russianFont));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                foreach (DataRow row in table.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), russianFont));
                        pdfTable.AddCell(cell);
                    }
                }

                doc.Add(pdfTable);
                Paragraph currentDatePara = new Paragraph();
                currentDatePara.Alignment = Element.ALIGN_CENTER;
                currentDatePara.Add(new Phrase($"{DateTime.Now.ToString("dd.MM.yyyy")}", russianFont));
                currentDatePara.SpacingBefore = 10f;
                doc.Add(currentDatePara);

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
}
