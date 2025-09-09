using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Data.SqlClient;
using Warehouse_System.Models;
using Warehouse_System.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Warehouse_System
{
    public partial class WarehouseManagerUI: Form
    {
        public WarehouseManagerUI()
        {
            InitializeComponent();
            Load_DaysDuration();
        }

        private void Load_DaysDuration()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Past 5 days");
            comboBox1.Items.Add("Past 15 days");
            comboBox1.Items.Add("Past 30 days");
            comboBox1.SelectedIndex = 0;
        }

        private void WarehouseManagerUI_Load(object sender, EventArgs e)
        {

        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            //Defining the variable that takes the selected item in the combobox
            string filter = comboBox1.SelectedItem?.ToString();

            //Validating the Combobox
            if (string.IsNullOrEmpty(filter))
            {
                MessageBox.Show("Please select a time filter");
                return;
            }

            //Switch Operator to set the Days duaration
            int daysSince;
            switch (filter)
            {
                case "Past 5 days" :
                    daysSince = 5;
                    break;

                case "Past 15 days":
                    daysSince = 15;
                    break;

                case "Past 30 days":
                    daysSince = 30;
                    break;

                default :
                    daysSince = 30;
                    break;
            };

            //Finding the starting date for the Tables 
            DateTime startDate = DateTime.Now.AddDays(-daysSince);

            //Creating the Connection String
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True";
            var report = new Models.ReportGen(conString);

            DataTable restockTable = report.GetRestockReport(startDate);
            DataTable dispatchTable = report.GetDispatchReport(startDate);
            DataTable productsTable = report.GetProductsReport();
            var (topDispatched, topRestocked, topSupplier) = report.GetInsights(startDate);

            //Generating the Pdf Report
            string fileName = $"Warehouse_Report_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            
            //Creating a Document Object and Defining measurements
            Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            //Adding the Logo to the Report
            string logoPath = Path.Combine(Application.StartupPath, "Resources", "Stock-Infinite - Logo Main 2.png");
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
            logo.ScaleToFit(60f, 60f);
            logo.SetAbsolutePosition(45f, 770f);
            doc.Add(logo);

            //Adding the Title
            var title = new Paragraph($"Stock Infinite - Warehouse Report ({filter})", FontFactory.GetFont("Arial", BaseFont.CP1252, Font.Bold, 18))
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingBefore = 10f,
                SpacingAfter = 20f
            };
            doc.Add(title);

            addDivider(doc);

            AddSectionHeader(doc ,"Summary Insights");
            doc.Add(new Paragraph($"Most Dispatched Item: {topDispatched}", FontFactory.GetFont("Arial", 11)));
            doc.Add(new Paragraph($"Most Restocked Item: {topRestocked}", FontFactory.GetFont("Arial", 11)));
            doc.Add(new Paragraph($"Most Supplier on Demand: {topSupplier}", FontFactory.GetFont("Arial", 11)));

            addDivider(doc);

            //Restocked Charts
            AddSectionHeader(doc, "Top 5 Restocked Items (Chart View)");
            AddChartToPDF(doc, restockTable, "QTY", "ProductName", "TopRestocked");

            //Dispatched Charts
            AddSectionHeader(doc, "Top 5 Dispatched Items (Chart View)");
            AddChartToPDF(doc, dispatchTable, "QTY", "ProductName", "TopDispatched");

            addDivider(doc);

            AddSectionHeader(doc, "Restocked Items");
            AddTableToPDF(doc, restockTable);

            addDivider(doc);

            AddSectionHeader(doc, "Dispatched Items");
            AddTableToPDF(doc, dispatchTable);

            addDivider(doc);

            AddSectionHeader(doc, "Stored Products");
            AddTableToPDF(doc, productsTable);

            addDivider(doc);

            doc.Close();
            MessageBox.Show("PDF report generated at: \n" + path, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddSectionHeader(Document doc, string text)
        {
            var headerFont = iTextSharp.text.FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
            Paragraph header = new Paragraph(text, headerFont)
            {
                Alignment = Element.ALIGN_LEFT,
                SpacingBefore = 15f,
                SpacingAfter = 8f
            };
            doc.Add(header);
        }

        private void AddTableToPDF(Document doc, DataTable dt)
        {
            PdfPTable pdfPTable = new PdfPTable(dt.Columns.Count);
            pdfPTable.WidthPercentage = 100;
            pdfPTable.SpacingBefore = 10f;
            pdfPTable.SpacingAfter = 10f;

            
            foreach (DataColumn col in dt.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.ColumnName, iTextSharp.text.FontFactory.GetFont("Arial", 10f, iTextSharp.text.Font.BOLD, BaseColor.WHITE)));
                cell.BackgroundColor = BaseColor.DARK_GRAY;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Padding = 5f;
                pdfPTable.AddCell(cell);
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (var cellData in row.ItemArray)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(cellData?.ToString(), iTextSharp.text.FontFactory.GetFont("Arial", 9)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 4f;
                    pdfPTable.AddCell(cell);
                }
            }
            doc.Add(pdfPTable);
        }

        private void addDivider(Document doc)
        {
            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator()))
            {
                SpacingBefore = 10f,
                SpacingAfter = 10f
            };
            doc.Add(line);
        }

        //Helper to add Chart to the PDF
        private void AddChartToPDF(Document doc, DataTable dt, string yCol, string xCol, string chartTitle)
        {
            using (var chart = new System.Windows.Forms.DataVisualization.Charting.Chart())
            {
                chart.Size = new System.Drawing.Size(600, 300);
                chart.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("Default"));

                var series = new System.Windows.Forms.DataVisualization.Charting.Series(chartTitle)
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column, IsValueShownAsLabel = true
                };

                var top5 = dt.AsEnumerable()
                    .OrderByDescending(r => Convert.ToInt32(r[yCol]))
                    .Take(5);

                foreach (var row in top5)
                {
                    series.Points.AddXY(row[xCol].ToString(), Convert.ToInt32(row[yCol]));
                }

                chart.Series.Add(series);

                //Save it as an Image
                string chartPath = Path.Combine(Path.GetTempPath(), $"{chartTitle}.png");
                chart.SaveImage(chartPath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

                //Adding the Image to PDF
                iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(chartPath);
                chartImage.Alignment = Element.ALIGN_CENTER;
                chartImage.ScaleToFit(500f, 250f);
                chartImage.SpacingBefore = 10f;
                chartImage.SpacingAfter = 10f;
                doc.Add(chartImage);
            }
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }

        private void ManageAccessories_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AccessoryForm().ShowDialog();
            this.Close();
        }

        private void ManageProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductForm().ShowDialog();
            this.Close();
        }

        private void RestockProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductRestockForm("manager").ShowDialog();
            this.Close();
        }

        private void DispatchProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DispatchForm("manager").ShowDialog();
            this.Close();
        }
    }
}
