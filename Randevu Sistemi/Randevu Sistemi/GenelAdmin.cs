using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Sistemi
{
    public class GenelAdmin:IIslemYapabilen
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        private List<Isyeri> IsyeriListesi { get; set; }
        
        public GenelAdmin()
        {
            IsyeriListesi = new List<Isyeri>();
        }

        Isyeri isyeri = new Isyeri();
        public void IsyeriEkle(string Adi, string Kategori, string adresi, string telNo, string YetkiliAdi)
        {
            
            isyeri.IsyeriAdi = Adi;
            isyeri.IsyeriAdresi = adresi;
            isyeri.IsyeriKategori = Kategori;
            isyeri.IsyeriTelefonNo = telNo;
            isyeri.IsyeriYetkilisi.AdiSoyadi = YetkiliAdi;
            IsyeriListesi.Add(isyeri);
        }


       
        public void IsyeriSil(string IsyeriAdi)
        {
            if (isyeri.IsyeriAdi == IsyeriAdi)
            {
                IsyeriListesi.Remove(isyeri);
            }
        }


    }
}
