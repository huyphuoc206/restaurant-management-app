using iTextSharp.text;
using iTextSharp.text.pdf;
using RestaurantApp.Model;
using RestaurantApp.ModelData;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            sfd.FileName = DateTime.Now.ToString("dd-MM-yyyy") + "_" + DateTime.Now.ToString("HH-mm-ss") + ".pdf";
            bool fileError = false;
            Paragraph name = new Paragraph(BillData.RESTAURANT_NAME, new Font(bf, 30, Font.BOLD));
            name.Alignment = Element.ALIGN_CENTER;
            Paragraph address = new Paragraph(BillData.address, new Font(bf, 15, Font.ITALIC));
            address.Alignment = Element.ALIGN_CENTER;
            Paragraph title = new Paragraph("PHIẾU THANH TOÁN " + billData.tableName.ToUpper(), new Font(bf, 25, Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            Paragraph orderId = new Paragraph("Mã hóa đơn: " + billData.orderId, new Font(bf, 12, Font.NORMAL));
            Paragraph staff = new Paragraph("Thu ngân: " + LoginInfo.Fullname, new Font(bf, 12, Font.NORMAL));
            Paragraph checkin = new Paragraph("Ngày / giờ vào: " + billData.checkin.ToString("dd/MM/yyyy HH:mm:ss"), new Font(bf, 12, Font.NORMAL));
            Paragraph checkout = new Paragraph("Ngày / giờ ra: " + billData.checkout.ToString("dd/MM/yyyy HH:mm:ss"), new Font(bf, 12, Font.NORMAL)); ;
            Paragraph sale = new Paragraph("Chương trình giảm giá: " + billData.sale.Name, new Font(bf, 12, Font.BOLD));
            Paragraph discount = new Paragraph("Giảm giá: " + billData.sale.Discount + "%", new Font(bf, 12, Font.BOLD));
            Paragraph totalPrice = new Paragraph("Tổng thanh toán: " + billData.totalPrice, new Font(bf, 12, Font.BOLD));
            Paragraph[] p = { orderId, staff, checkin, checkout, sale, discount, totalPrice };
            foreach (Paragraph item in p)
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
                            for (int i = 0; i < itemRow.SubItems.Count; i++)
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
                            if(billData.sale.Discount != 0)
                            {
                                pdfDoc.Add(sale);
                                pdfDoc.Add(discount);
                            }                       
                            pdfDoc.Add(totalPrice);
                            pdfDoc.Add(new Chunk("\n"));
                            pdfDoc.Add(wifi);
                            pdfDoc.Add(thanks);
                            pdfDoc.Add(bye);
                            pdfDoc.Close();
                            stream.Close();
                        }
                        MessageBox.Show("In hóa đơn " + billData.tableName.ToLower() + " thành công!!!", "Thông báo");
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

        public static void PrintingReport(DataGridView data, ReportInfo report)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            //Full path to the Unicode Arial file
            string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

            //Create a base font object making sure to specify IDENTITY-H
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //Create a specific font object
            Font f = new Font(bf, 12, Font.NORMAL);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "BaoCaoDoanhThu_" + report.fromDate.ToString("dd-MM-yyyy") + "_" + report.toDate.ToString("dd-MM-yyyy") + ".pdf";
            bool fileError = false;

            Paragraph name = new Paragraph("Tên đơn vị: " + BillData.RESTAURANT_NAME, new Font(bf, 15, Font.BOLD));
            Paragraph address = new Paragraph("Địa chỉ: " + BillData.address, new Font(bf, 15, Font.ITALIC));
            Paragraph title = new Paragraph("BẢNG BÁO CÁO DOANH THU", new Font(bf, 25, Font.BOLD));
            title.Alignment = Element.ALIGN_CENTER;
            Paragraph date = new Paragraph("Từ ngày " + report.fromDate.ToString("dd/MM/yyyy") + " đến " + report.toDate.ToString("dd/MM/yyyy"), new Font(bf, 14, Font.ITALIC));
            date.Alignment = Element.ALIGN_CENTER;
            Paragraph countOrder = new Paragraph("Số lượng đơn hàng: " + report.countOrder, new Font(bf, 12, Font.NORMAL));
            Paragraph totalPrice = new Paragraph("Tổng doanh thu: " + report.totalPriceOrder.ToString(culture), new Font(bf, 12, Font.NORMAL));

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
                        PdfPTable pdfTable = new PdfPTable(data.Columns.Count - 2);
                        pdfTable.DefaultCell.Padding = 5;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.DefaultCell.BorderWidth = 1;
                        //Adding Header row


                        int colStatus = -1;
                        int colModifiedBy = -1;
                        foreach (DataGridViewColumn column in data.Columns)
                        {
                            if (column.Name.Equals("Status"))
                            {
                                colStatus = column.Index;
                                continue;
                            }

                            if (column.Name.Equals("ModifiedBy"))
                            {
                                colModifiedBy = column.Index;
                                continue;
                            }
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f)) { HorizontalAlignment = Element.ALIGN_CENTER };
                            cell.BackgroundColor = new BaseColor(226, 226, 226);
                            pdfTable.AddCell(cell);
                        }

                        //Adding DataRow
                        foreach (DataGridViewRow row in data.Rows)
                        {
                            int i = 0;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.ColumnIndex == colStatus || cell.ColumnIndex == colModifiedBy) continue;
                                int align = Element.ALIGN_LEFT;
                                if (i == 3 || i == 4 || i == 6 || i==5) align = Element.ALIGN_CENTER;
                                PdfPCell c;
                                if (i == 0)
                                {
                                    long total = (long)cell.Value;
                                    c = new PdfPCell(new Phrase(total.ToString("C0", culture), f)) { HorizontalAlignment = align };
                                }

                                else
                                    c = new PdfPCell(new Phrase(cell.Value.ToString(), f)) { HorizontalAlignment = align };
                                pdfTable.AddCell(c);
                                i++;
                            }
                        }

                        //Exporting to PDF                
                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A3, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(name);
                            pdfDoc.Add(address);
                            pdfDoc.Add(title);
                            pdfDoc.Add(date);
                            pdfDoc.Add(new Chunk("\n"));
                            pdfDoc.Add(countOrder);
                            pdfDoc.Add(totalPrice);
                            pdfDoc.Add(new Chunk("\n"));
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }
                        MessageBox.Show("In báo cáo doanh thu thành công!!!", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mô tả lỗi :" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có báo cáo nào được in!!!", "Thông báo");
            }
        }
    }
}
