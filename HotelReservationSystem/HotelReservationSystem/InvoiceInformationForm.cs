using HotelReservationSystem.DAL;
using HotelReservationSystem.DOMAIN;
using HotelReservationSystem.SERVICES;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelReservationSystem
{
    public partial class InvoiceInformationForm : Form
    {
        InvoiceService _invoiceService = new InvoiceService();
        int _invoiceId = 0;
        public InvoiceInformationForm()
        {
            InitializeComponent();
        }

        private void InvoiceInformationForm_Load(object sender, EventArgs e)
        {
            InvoiceDataGridView.DataSource= _invoiceService.GetDataTable();
        }

      

       

        private void invoicePrintBtn_Click(object sender, EventArgs e)
        {
            if (_invoiceId!=0)
           { 
                string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            // Kaydedilecek PDF dosyasının tam yolu
            string filePath = Path.Combine(downloadsFolder, _invoiceService.InvoiceNameSurname(_invoiceId));

            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Tablo başlıklarını PDF'ye ekle
                    Table table = new Table(_invoiceService.InvoiceWritePdf(_invoiceId).Columns.Count);
                    foreach (DataColumn column in _invoiceService.InvoiceWritePdf(_invoiceId).Columns)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(column.ColumnName)));
                    }

                    // Satırları PDF'ye ekle
                    foreach (DataRow row in _invoiceService.InvoiceWritePdf(_invoiceId).Rows)
                    {
                        foreach (var cell in row.ItemArray)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(cell.ToString())));
                        }
                    }

                    // Tabloyu PDF'ye ekle
                    document.Add(table);
                }
            }

                MessageBox.Show("PDF başarıyla oluşturuldu: " + filePath);
            }
            else
            {
                MessageBox.Show("Lütfen bir Fatura seçiniz");
            }
        }

        private void InvoiceDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = InvoiceDataGridView.SelectedRows[0];
                _invoiceId = Convert.ToInt32(selectedRow.Cells["invoicesID"].Value);

            }
            catch (Exception)
            {


            }
           
        }

        private void invoiceSearch_ValueChanged(object sender, EventArgs e)
        {
            DateTime filter = invoiceSearch.Value.Date; // Seçilen tarihi al
            Console.WriteLine(filter); // Konsola yazdır, kontrol için

            DataView dv =_invoiceService.GetDataTable().DefaultView;

            // RowFilter ifadesi
            dv.RowFilter = $"invoiceDate >= '#{filter:yyyy-MM-dd}#'";

            // DataGridView'e filtrelenmiş veriyi bağla
            InvoiceDataGridView.DataSource = dv;
        }

        private void invoiceOutBtn_Click(object sender, EventArgs e)
        {
            InvoiceDataGridView.DataSource = _invoiceService.GetDataTable();
        }


    }
}
