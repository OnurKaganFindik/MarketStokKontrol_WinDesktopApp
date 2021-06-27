using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStokKontrol_WinDesktopApp
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAd { get; set; }
        public int? UstKategoriId { get; set; }
    }
}
