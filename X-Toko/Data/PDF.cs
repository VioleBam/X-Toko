using System;
using System.IO;
using X_Toko.Data;

using UglyToad.PdfPig.Core;
using UglyToad.PdfPig.Writer;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.Fonts.Standard14Fonts;
using System.Collections.Generic;

namespace X_Toko
{
    public class PDF
    {
        private Files file = new Files();
        private Pesan pesan = new Pesan();
        private Properti properti = new Properti();

        public bool SavePDF(string nama_file)
        {
            string nama = string.Concat(nama_file, ".pdf");

            try
            {
                file.DeleteFile(nama);

                PdfDocumentBuilder builder = new PdfDocumentBuilder();
                PdfDocumentBuilder.AddedFont times = builder.AddStandard14Font(Standard14Font.TimesBold);
                PdfDocumentBuilder.AddedFont helvetica = builder.AddStandard14Font(Standard14Font.Helvetica);
                PdfDocumentBuilder.AddedFont helveticaBold = builder.AddStandard14Font(Standard14Font.HelveticaBold);
                PdfPageBuilder page = builder.AddPage(PageSize.A4, false);

                PdfPoint closeToTop = new PdfPoint(15, page.PageSize.Top - 25);

                PdfPoint awal = new PdfPoint(page.PageSize.Left + 15, page.PageSize.Top - 80);
                PdfPoint akhir = new PdfPoint(page.PageSize.Right - 15, page.PageSize.Top - 80);

                PdfPoint headerText = new PdfPoint(page.PageSize.Left, page.PageSize.Top - 97);


                // Data Toko
                page.AddText(file.NamaToko, 22, closeToTop, times);
                page.AddText("TELEPON : " + file.TeleponToko, 12, closeToTop.Translate(0, -18), times);
                page.AddText("ALAMAT  : " + file.AlamatToko, 12, closeToTop.Translate(0, -30), times);

                // Title
                if (nama_file.Equals("Supplier"))
                    page.AddText(string.Concat("DAFTAR ", nama_file.ToUpper()), 32, closeToTop.Translate(510, -25), times);
                else
                    page.AddText(string.Concat("DAFTAR ", nama_file.ToUpper()), 32, closeToTop.Translate(484, -25), times);

                // Lines
                page.DrawLine(awal, akhir, 1);
                page.AddText("KODE", 12, headerText.MoveX(15), helvetica);
                page.AddText(string.Concat("NAMA ", nama_file.ToUpper()), 12, headerText.MoveX(115), helvetica);
                page.AddText(string.Concat("ALAMAT ", nama_file.ToUpper()), 12, headerText.MoveX(340), helvetica);
                page.AddText("TELEPON", 12, headerText.MoveX(735), helvetica);
                page.DrawLine(awal.MoveY(-25), akhir.MoveY(-25), 1);

                ContentTable(page, helvetica, string.Concat("tbl", nama_file), nama_file);

                file.WriteAllBytes(nama, builder.Build());
                pesan.IsiPesan = string.Concat("File PDF berhasil dibuat dengan nama ", nama);
                return true;
            }
            catch (IOException ex)
            {
                pesan.IsiPesan = ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                pesan.IsiPesan = ex.Message;
                return false;
            }
        }

        private void ContentTable(PdfPageBuilder page, PdfDocumentBuilder.AddedFont font, string nama_table, string nama_file)
        {
            PdfPoint contentText = new PdfPoint(page.PageSize.Left, page.PageSize.Top - 117);
            List<Properti> rows = properti.Read(file.DatabasePath);

            int y = 15;
            int x  = 0, index = 0;
            foreach (Properti row in rows)
            {
                index = rows.IndexOf(row);
                if (index == 0)
                {
                    page.AddText(row.PropertiKode.ToString(), 10, contentText.Translate(15, -5), font);
                    page.AddText(row.PropertiNama.ToString(), 10, contentText.Translate(115, -5), font);
                    page.AddText(row.PropertiAlamat.ToString(), 10, contentText.Translate(340, -5), font);
                    page.AddText(row.PropertiTelepon.ToString(), 10, contentText.Translate(735, -5), font);
                }
                else
                {
                    x = 5 + y;
                    y += 15;
                    page.AddText(row.PropertiKode.ToString(), 10, contentText.Translate(15, -x), font);
                    page.AddText(row.PropertiNama.ToString(), 10, contentText.Translate(115, -x), font);
                    page.AddText(row.PropertiAlamat.ToString(), 10, contentText.Translate(340, -x), font);
                    page.AddText(row.PropertiTelepon.ToString(), 10, contentText.Translate(735, -x), font);
                }
            }       
        }
    }
}
