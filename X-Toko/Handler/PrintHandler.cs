using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using X_Toko.Data;

namespace X_Toko
{
    public class PrintHandler 
    {
        private Files file = new Files();
        private List<PrintTransaksi> pt = new List<PrintTransaksi>();
        static int width = 0, height = 0;

        public List<PrintTransaksi> PT 
        {
            set { pt = value; }
        }

        public void prntTransaksi_PrintPage(object sender, PrintPageEventArgs e)
        {
           Pen pen = new Pen(Brushes.Black);
           Pen penBold = new Pen(Brushes.Black, 5);

           width = e.PageSettings.PaperSize.Width;
           height = e.PageSettings.PaperSize.Height;
           
            // Draw Header
           Rectangle headerRect = new Rectangle(20, 20, width - 50, 60);
           //e.Graphics.FillRectangle(Brushes.GreenYellow, headerRect);
           invHead(e,headerRect, file.NamaToko, file.AlamatToko, file.TeleponToko);

           // I N V O I C E
           Rectangle inv = new Rectangle(20, 80, width - 30, 80);
           using (Font font = new Font("Times new Roman", 18, FontStyle.Bold))
           {
               e.Graphics.DrawString("I N V O I C E", font, Brushes.Black, 640, 50, new StringFormat());
           }
           
           // Divider
           Rectangle div01 = new Rectangle(20, 80, width-30, 80);
           e.Graphics.DrawLine(pen, div01.X, div01.Y, div01.Width, div01.Height);
           Rectangle div02 = new Rectangle(20, 85, width-30, 85);
           e.Graphics.DrawLine(penBold, div02.X, div02.Y, div02.Width, div02.Height);

           // Draw Customer Detail
           Rectangle custRect = new Rectangle(20, 90, width-50, 75);
           //e.Graphics.FillRectangle(Brushes.GreenYellow, custRect);
           //invCustomer(e, custRect, file.NamaToko, file.AlamatToko, file.TeleponToko, "23 November 2005","87647886435786", /*cust.Cek*/cfg.Customer);

           // Draw Table
           Rectangle tblRect = new Rectangle(20, 170, width - 50, 200);
           //e.Graphics.FillRectangle(Brushes.GreenYellow, tblRect);
           invData(e, tblRect.X, tblRect.Y, tblRect.Width, tblRect.Height);
        }

        private void invHead(PrintPageEventArgs e, Rectangle rect, String nama, String alamat, String telepon)
        {
            Pen pen = new Pen(Brushes.Black);

            using (Font font = new Font("Arial", 18, FontStyle.Bold))
            {
                e.Graphics.DrawString(nama, font, Brushes.Black, rect.X, rect.Y, new StringFormat());

            }
            using (Font font = new Font("Arial", 10))
            {
                e.Graphics.DrawString("Alamat", font, Brushes.Black, rect.X, rect.Y + 25, new StringFormat());
                e.Graphics.DrawString(":", font, Brushes.Black, rect.X + 50, rect.Y + 25, new StringFormat());
                e.Graphics.DrawString(alamat, font, Brushes.Black, rect.X + 60, rect.Y + 25, new StringFormat());
                e.Graphics.DrawString("Telepon", font, Brushes.Black, rect.X, rect.Y + 40, new StringFormat());
                e.Graphics.DrawString(":", font, Brushes.Black, rect.X + 50, rect.Y + 40, new StringFormat());
                e.Graphics.DrawString(telepon, font, Brushes.Black, rect.X + 60, rect.Y + 40, new StringFormat());
            }
        }
      
        private void invHead(PrintPageEventArgs e, Rectangle rect, String pathLogo, String nama, String alamat, String telepon) 
        {
            Pen pen = new Pen(Brushes.Black);

            using (Font font = new Font("Arial", 18, FontStyle.Bold))
            {
                //Image img = Image.FromFile(pathLogo);
                //Rectangle logo = new Rectangle(40, 40, 50, 50);
                //e.Graphics.DrawImage(img, logo);
                e.Graphics.DrawString(nama, font, Brushes.Black, rect.X, rect.Y, new StringFormat());

            }
            using (Font font = new Font("Arial", 10))
            {
                e.Graphics.DrawString("Alamat: ", font, Brushes.Black, rect.X, rect.Y + 25, new StringFormat());
                e.Graphics.DrawString(alamat, font, Brushes.Black, rect.X + 60, rect.Y + 25, new StringFormat());
                e.Graphics.DrawString("Telepon: ", font, Brushes.Black, rect.X, rect.Y + 40, new StringFormat());
                e.Graphics.DrawString(telepon, font, Brushes.Black, rect.X + 60, rect.Y + 40, new StringFormat());
            }
        }

        private void invCustomer(PrintPageEventArgs e, Rectangle rect, String nama, String alamat, String telepon, String tgl, String nomer, Boolean cek)
        {
            Pen pen = new Pen(Brushes.Black);

            if (cek == true)
            {
                using (Font font = new Font("Arial", 12, FontStyle.Bold))
                {
                    e.Graphics.DrawString("Customer Detail", font, Brushes.Black, rect.X, rect.Y, new StringFormat());
                }

                using (Font font = new Font("Arial", 10))
                {
                    e.Graphics.DrawString("Nama", font, Brushes.Black, rect.X, rect.Y + 25, new StringFormat());
                    e.Graphics.DrawString(":", font, Brushes.Black, rect.X + 60, rect.Y + 25, new StringFormat());
                    e.Graphics.DrawString(nama, font, Brushes.Black, rect.X + 70, rect.Y + 25, new StringFormat());
                    e.Graphics.DrawString("Telepon", font, Brushes.Black, rect.X, rect.Y + 40, new StringFormat());
                    e.Graphics.DrawString(":", font, Brushes.Black, rect.X + 60, rect.Y + 40, new StringFormat());
                    e.Graphics.DrawString(telepon, font, Brushes.Black, rect.X + 70, rect.Y + 40, new StringFormat());
                    e.Graphics.DrawString("Alamat", font, Brushes.Black, rect.X, rect.Y + 55, new StringFormat());
                    e.Graphics.DrawString(":", font, Brushes.Black, rect.X + 60, rect.Y + 55, new StringFormat());
                    e.Graphics.DrawString(alamat, font, Brushes.Black, rect.X + 70, rect.Y + 55, new StringFormat());

                }
            }
            using (Font font = new Font("Arial", 12, FontStyle.Bold))
            {
                e.Graphics.DrawString("Order Detail", font, Brushes.Black, (width - 40) / 2, rect.Y, new StringFormat());
            }

            using (Font font = new Font("Arial", 10))
            {
                e.Graphics.DrawString("Tanggal", font, Brushes.Black, (width - 40) / 2, rect.Y + 25, new StringFormat());
                e.Graphics.DrawString(":", font, Brushes.Black, (width - 40) / 2 + 80, rect.Y + 25, new StringFormat());
                e.Graphics.DrawString(tgl, font, Brushes.Black, (width - 40) / 2 + 90, rect.Y + 25, new StringFormat());
                e.Graphics.DrawString("No. Invoice", font, Brushes.Black, (width - 40) / 2, rect.Y + 40, new StringFormat());
                e.Graphics.DrawString(":", font, Brushes.Black, (width - 40) / 2 + 80, rect.Y + 40, new StringFormat());
                e.Graphics.DrawString(nomer, font, Brushes.Black, (width - 40) / 2 + 90, rect.Y + 40, new StringFormat());
            }
        }

        private void invData(PrintPageEventArgs e, int x, int y, int width, int height)
        {
            Rectangle main = new Rectangle(x, y, width, height); // Kotak Tabel

            int szNo = x + 15;
            int szNama = x + szNo + 400;
            int szQty = x + szNama + 60;
            int szHarga = x + szQty + 140;
            Pen pen = new Pen(Brushes.Black);
            
            e.Graphics.DrawRectangle(pen,main);
            // Garis Header
            Horisontal(e,pen,main,20);
            // Garis Nomer
            Vertikal(e,pen,main,szNo);
            // Garis Nama Barang
            Vertikal(e,pen,main,szNama);
            // Garis Quantity
            Vertikal(e,pen,main,szQty);
            // Garis Harga Satuan
            Vertikal(e,pen,main,szHarga);

            using (Font font = new Font("Arial", 10))
            {
                int counter = 0;
                for(int i = 0; i < pt.Count; i++)
                {
                    counter++;
                    e.Graphics.DrawString(counter.ToString(), font, Brushes.Black, x + 10, y + 25, new StringFormat());
                    e.Graphics.DrawString(pt[i].NamaBarang, font, Brushes.Black, x + 50, y + 25, new StringFormat());
                    e.Graphics.DrawString(pt[i].QtyBarang.ToString(), font, Brushes.Black, x + 500, y + 25, new StringFormat());
                }
            }
        }

        private void invFoot(PrintPageEventArgs e, int x, int y, String pathLogo, String title)
        {
            Pen pen = new Pen(Brushes.Black);

            using (Font font = new Font("Arial", 20.0f))
            {
                Image img = Image.FromFile(pathLogo);
                Rectangle logo = new Rectangle(40, 40, 50, 50);
                e.Graphics.DrawImage(img, logo);
                e.Graphics.DrawString(title, font, Brushes.Black, x, y, new StringFormat());
            }

        }

        private void Horisontal(PrintPageEventArgs e, Pen pen, Rectangle rect, int size)
        {
            Point[] titik = {
                 new Point(rect.X, rect.Y + size),
                 new Point(rect.X + rect.Width, rect.Y + size),
             };

            e.Graphics.DrawLines(pen, titik);
        }

        private void Vertikal(PrintPageEventArgs e, Pen pen, Rectangle rect, int size)
        {
            Point[] titik = {
                 new Point(rect.X + size, rect.Y),
                 new Point(rect.X + size, rect.Y + rect.Height),
             };

            e.Graphics.DrawLines(pen, titik);
        }
    }
}
