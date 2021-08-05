using Data;
using Datas;
using iTextSharp.text;
using iTextSharp.text.pdf;
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

namespace Restaurante
{
    public partial class fInvoice : Form
    {
        public fInvoice(int maban)
        {
            InitializeComponent();
            txtIdTable.Text = maban.ToString();
            LoadBill(maban);
        }

        void LoadBill(int maban)
        {
            dtgvBill.DataSource = Datas.Menu.Instance.LoadBillByIdTable(maban);
            DataRow row = Factura.Instance.GetInforBillByIdTable(maban);
            if (row != null)
            {
                txtIdBill.Text = ((int)row["MAHOADON"]).ToString();
                txtIdTable.Text = ((int)row["MABAN"]).ToString();
                DateTime now = DateTime.Now;
                txtDate.Text = now.ToString();
                txtTotal.Text = TongTien(maban).ToString();

            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            try
            {
                int mahoadon = Convert.ToInt32(txtIdBill.Text);
                int tongtien = Convert.ToInt32(txtTotal.Text);
                int maban = Convert.ToInt32(txtIdTable.Text);
                DateTime ngaythanhtoan = Convert.ToDateTime(txtDate.Text);
                MessageBox.Show($"UpdateBill |{Factura.Instance.UpdateBill(mahoadon, ngaythanhtoan, tongtien)}|");
                if (Factura.Instance.UpdateBill(mahoadon, ngaythanhtoan, tongtien) == true)
                {
                    Factura.Instance.Checkout(mahoadon);
                    Mesas.Instance.ResetStatusById(maban);
                    MessageBox.Show($"Pago exitoso |Checkout|  {mahoadon}  |ResetStatusById| {maban}");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("La informacion esta vacia");
            }
            if (dtgvBill.Rows.Count > 0)
            {
                int mahoadon = Convert.ToInt32(txtIdBill.Text);
                int tongtien = Convert.ToInt32(txtTotal.Text);
                int maban = Convert.ToInt32(txtIdTable.Text);
                DateTime ngaythanhtoan = Convert.ToDateTime(txtDate.Text);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Mahoadon-" + mahoadon + ".pdf";
                bool fileError = false;
                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f1 = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No se pueden escribir datos en la unidad. Error de descripción:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtgvBill.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            // Agregar nombre de columna
                            foreach (DataGridViewColumn column in dtgvBill.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f));
                                pdfTable.AddCell(cell);
                            }
                            // Agregar datos en cada columna
                            foreach (DataGridViewRow row in dtgvBill.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value == null)
                                    {
                                        pdfTable.AddCell(new Phrase("", f));
                                    }
                                    else
                                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), f));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                //Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                //PdfWriter.GetInstance(pdfDoc, stream);
                                //pdfDoc.Open();
                                //Paragraph para3 = new Paragraph("RESTAURANTE DELTA", f2);
                                //Paragraph para4 = new Paragraph("Dirección: casa número 123, barrio de Dong Hoa, ciudad de Di An, provincia de Binh Duong", f);
                                //Paragraph para5 = new Paragraph("Teléfono: 0388888888-0345678989", f);
                                //Paragraph para6 = new Paragraph("Correo electrónico: DNLrestaurant@gmail.com", f);
                                //Paragraph para7 = new Paragraph("FACTURA DE VENTA", f1);
                                //Paragraph para8 = new Paragraph("* * *", f1);
                                //Paragraph para9 = new Paragraph("------------------------------------------------------------", f);
                                //Paragraph para1 = new Paragraph("Mesa " + txtIdTable.Text, f2);
                                //Paragraph para = new Paragraph($"Factura de código: {txtIdBill.Text} Día: {txtDate.Text}", f);
                                //Paragraph para2 = new Paragraph($"Código de mesa: {txtIdTable.Text} Total: {txtTotal.Text}", f);
                                //para3.Alignment = Element.ALIGN_CENTER;
                                //para4.Alignment = Element.ALIGN_CENTER;
                                //para5.Alignment = Element.ALIGN_CENTER;
                                //para6.Alignment = Element.ALIGN_CENTER;
                                //para1.Alignment = Element.ALIGN_CENTER;
                                //para7.Alignment = Element.ALIGN_CENTER;
                                //para8.Alignment = Element.ALIGN_CENTER;
                                //para9.Alignment = Element.ALIGN_CENTER;
                                //para2.Alignment = Element.ALIGN_LEFT;
                                //para.Alignment = Element.ALIGN_LEFT;

                                //pdfDoc.Add(para3);
                                //pdfDoc.Add(para4);
                                //pdfDoc.Add(para5);
                                //pdfDoc.Add(para6);
                                //pdfDoc.Add(para9);
                                //pdfDoc.Add(para7);
                                //pdfDoc.Add(new Phrase(" "));
                                //pdfDoc.Add(para1);
                                //pdfDoc.Add(new Phrase(" "));
                                //pdfDoc.Add(para);
                                //pdfDoc.Add(para2);

                                //pdfDoc.Add(new Phrase(" "));
                                //pdfDoc.Add(pdfTable);
                                //pdfDoc.Add(new Phrase(" "));
                                //pdfDoc.Add(para8);
                                //pdfDoc.Close();
                                //stream.Close();
                            }

                            MessageBox.Show("Factura exitosa !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error de descripción:" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("¡No se emite ninguna factura!", "Info");
            }
            this.Close();



        }

        private void dtgvBill_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvBill.Rows[e.RowIndex];
                txtFoodName.Text = row.Cells["El nombre de la comida"].Value.ToString();
                txtUnitPrice.Text = row.Cells["Precio"].Value.ToString();
                txtCount.Text = row.Cells["Monto"].Value.ToString();
                txtPrice.Text = row.Cells["en dinero"].Value.ToString();
            }
        }

        int TongTien(int MABAN)
        {
            List<DataMenu> menus = Datas.Menu.Instance.GetListMenusById(MABAN);

            int tongtien = 0;
            foreach (var i in menus)
            {
                tongtien += i.Thanhtien;
            }
            return tongtien;
        }

        private void fInvoice_Load(object sender, EventArgs e)
        {
            MySQL.Initialize();
            this.Height = 724;
            this.Width = 1426;
        }

    }
}
