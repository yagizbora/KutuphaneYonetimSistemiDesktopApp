using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimSistemi.Models
{
    public class AdminUserAuthModels
    {
        public string? password { get; set; }
    }
   public class AdminUserModels
    {
        public int? id { get; set; }
        public string? KullanıcıAdı { get; set; }
        public string? Şifre { get; set; }
    }
    public class AdminUserModelsFilters
    {
        public string? KullaniciAdi { get; set; }
        public string? Sifre { get; set; }
    }
}
