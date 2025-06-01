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

            var title = new Paragraph($"Stock Infinite - Warehouse Report ({filter})", FontFactory.GetFont("Arial", BaseFont.CP1252,Font.Bold, 18));
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            addDivider(doc);

            doc.Add(new Paragraph("\n--- Summary Insights---\n"));
            doc.Add(new Paragraph($"Most Dispatched Item: {topDispatched} \n"));
            doc.Add(new Paragraph($"Most Restocked Item: {topRestocked} \n"));
            doc.Add(new Paragraph($"Most Supplier on Demand: {topSupplier}  \n"));

            addDivider(doc);

            doc.Add(new Paragraph("\n--- Restocked Items --- \n"));
            AddTableToPDF(doc, restockTable);

            addDivider(doc);

            doc.Add(new Paragraph("\n--- Dispatched Items --- \n", FontFactory.GetFont("Arial", BaseFont.HELVETICA, Font.Bold, 12)));
            AddTableToPDF(doc, dispatchTable);

            addDivider(doc);

            doc.Add(new Paragraph("\n--- Stored Products --- \n", FontFactory.GetFont("Arial", BaseFont.HELVETICA, Font.Bold, 12)));
            AddTableToPDF(doc, productsTable);

            addDivider(doc);

            doc.Close();
            MessageBox.Show("PDF report generated at: \n" + path);
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
                    PdfPCell cell = new PdfPCell(new Phrase(cellData?.ToString(), iTextSharp.text.FontFactory.GetFont("Arial", 7)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 3f;
                    pdfPTable.AddCell(cell);
                }
            }
            doc.Add(pdfPTable);
        }

        private void addDivider(Document doc)
        {
            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator()));
            doc.Add(line);
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
