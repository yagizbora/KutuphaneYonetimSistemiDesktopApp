using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.Models
{
   public class BookModels
    {
        public int? ID { get; set; }
        public string? KitapAdi { get; set; }
        public string? YazarAdi { get; set; }
        public string? YazarSoyadi { get; set; }
        public string? ISBN { get; set; }
        public bool? Durum { get; set; }
        public string? OduncAlan { get; set; }
        public DateOnly? OduncAlmaTarihi { get; set; }
        public int? KitapTurKodu { get; set; }
        public string? Aciklama { get; set; }
    }
}
