using iTextSharp.text;
using iTextSharp.text.pdf;
using RestaurantApp.Model;
using RestaurantApp.ModelData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Utils
{
    public class PDFUtil
    {
        public static void PrintingBill(ListView data, BillData billData)
        {
            //Full path to the Unicode Arial file
            string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

            //Create a base font object making sure to specify IDENTITY-H
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //Create a specific font object
            Font f = new Font(bf, 12, Font.NORMAL);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = DateTime.Now.ToString("dd/MM/yyyy") + "_" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + ".pdf";
            bool fileError = false;
            Paragraph name = new Paragraph(billData.RESTAURANT_NAME, new Font(bf, 30, Font.BOLD));
            name.Alignment = Element.ALIGN_CENTER;
            Paragraph address = new Paragraph(billData.address, new Font(bf, 15, Font.ITALIC));
            address.Alignment = Element.ALIGN_CENTER;
            Paragraph title = new Paragraph("PHIẾU THANH TOÁN", new Font(bf, 25, Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            Paragraph orderId = new Paragraph("Mã hóa đơn: "+billData.orderId, new Font(bf, 12, Font.NORMAL)); 
            Paragraph staff = new Paragraph("Thu ngân: " + LoginInfo.Fullname, new Font(bf, 12, Font.NORMAL));
            Paragraph table = new Paragraph(billData.tableName, new Font(bf, 12, Font.NORMAL));
            Paragraph checkin = new Paragraph("Ngày / giờ vào: " + billData.checkin.ToString("dd/MM/yyyy HH:mm:ss"), new Font(bf, 12, Font.NORMAL));
            Paragraph checkout = new Paragraph("Ngày / giờ ra: " + billData.checkout.ToString("dd/MM/yyyy HH:mm:ss"), new Font(bf, 12, Font.NORMAL)); ;
            Paragraph sale = new Paragraph("Chương trình giảm giá: "+ billData.sale.Name, new Font(bf, 12, Font.BOLD));
            Paragraph discount = new Paragraph("Giảm giá: "+ billData.sale.Discount+"%", new Font(bf, 12, Font.BOLD));
            Paragraph totalPrice = new Paragraph("Tổng thanh toán: "+ billData.totalPrice, new Font(bf, 12, Font.BOLD));
            Paragraph[] p = { orderId, staff, table, checkin, checkout, sale, discount, totalPrice };
            foreach(Paragraph item in p)
            {
                item.Alignment = Element.ALIGN_RIGHT;
                item.IndentationRight = 115;
            }
            Paragraph wifi = new Paragraph("Mật khẩu Wifi: laptrinh.net", new Font(bf, 12, Font.BOLD));
            wifi.Alignment = Element.ALIGN_CENTER;
            Paragraph thanks = new Paragraph("Xin cảm ơn quý khách", new Font(bf, 12, Font.NORMAL));
            thanks.Alignment = Element.ALIGN_CENTER;
            Paragraph bye = new Paragraph("Hẹn gặp lại quý khách lần sau", new Font(bf, 12, Font.NORMAL));
            bye.Alignment = Element.ALIGN_CENTER;
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
                        MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(data.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 60;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.DefaultCell.BorderWidth = 1;
                        //Adding Header row
                        foreach (ColumnHeader column in data.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.Text, f)) { HorizontalAlignment = Element.ALIGN_CENTER };
                            cell.BackgroundColor = new BaseColor(226, 226, 226);
                            pdfTable.AddCell(cell);
                        }

                        //Adding DataRow
                        foreach (ListViewItem itemRow in data.Items)
                        {
                            int i = 0;
                            for (i = 0; i < itemRow.SubItems.Count; i++)
                            {
                                int align = Element.ALIGN_RIGHT;
                                if (i == 0) align = Element.ALIGN_LEFT;
                                else if (i == 1) align = Element.ALIGN_CENTER;
                                PdfPCell cell = new PdfPCell(new Phrase(itemRow.SubItems[i].Text, f)) { HorizontalAlignment = align };
                                pdfTable.AddCell(cell);
                            }
                        }

                        //Exporting to PDF                
                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);                          
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(name);
                            pdfDoc.Add(address);
                            pdfDoc.Add(title);
                            pdfDoc.Add(new Chunk("\n"));
                            pdfDoc.Add(orderId);
                            pdfDoc.Add(staff);
                            pdfDoc.Add(checkin);
                            pdfDoc.Add(checkout);
                            pdfDoc.Add(new Chunk("\n"));
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Add(new Chunk("\n"));
                            pdfDoc.Add(sale);
                            pdfDoc.Add(discount);
                            pdfDoc.Add(totalPrice);
                            pdfDoc.Add(new Chunk("\n"));
                            pdfDoc.Add(wifi);
                            pdfDoc.Add(thanks);
                            pdfDoc.Add(bye);
                            pdfDoc.Close();
                            stream.Close();
                        }
                        MessageBox.Show("In hóa đơn thành công!!!", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mô tả lỗi :" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào được in!!!", "Thông báo");
            }
        }

    }
}
