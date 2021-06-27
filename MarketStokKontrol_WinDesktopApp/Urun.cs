using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokKontrol_WinDesktopApp
{
   public class Urun
    {

        public int Id { get; set; }
        public int KategoriId { get; set; }
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }
        public int StokAdet { get; set; }
        public byte[] Resim { get; set; }
        public Image ResimGetir()
        {
            if (Resim == null) return null;
            return (Bitmap)((new ImageConverter()).ConvertFrom(Resim));
        }
    }
}
