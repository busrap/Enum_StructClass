using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_StructClass_5
{
    class Ogrenci
    {
        public Ogrenci()
        {
            DersListesi = new List<Ders>();
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public List<Ders> DersListesi { get; set; }
        public Alani Bolumu { get; set; }

        public Durum Durumu
        {
            get
            {
                if (GenelBasari_ort >= 70)
                    return Durum.Geçti;
                else if (GenelBasari_ort <= 44)
                    return Durum.Kaldi;
                else
                    return Durum.SartliGecti;
            }
        }
        public decimal GenelBasari_ort
        {
            get
            {
                decimal toplam = 0;
                foreach (Ders item in DersListesi)
                {
                    toplam += item.Vize_Final_Ort;
                }
                return toplam / DersListesi.Count;
            }
        }
        public override string ToString()
        {
            return "Adı: " + Adi + "\nSoyadı: " + Soyadi + "\nGenel Başarı Ortalaması: " + Math.Round(GenelBasari_ort, 2);
        }
    }
    

    struct Ders
    {
        public string Ders_adi { get; set; }
        public decimal Vize { get; set; }
        public decimal Final { get; set; }
        public decimal Vize_Final_Ort
        {
            get
            {
                return Vize * 0.4m + Final * 0.6m;
            }
        }

        public override string ToString()
        {
            return " Ders Adı: " + this.Ders_adi + "    Vize: " + this.Vize + "    Final: " + this.Final + "    Ders Ortalaması: " + Math.Round(Vize_Final_Ort, 2);
        }
    }
    enum Durum
    {
        Geçti,
        Kaldi,
        SartliGecti
    }
    enum Alani
    {

        Sayisal,
        Sozel,
        EsitAgirlik,
        YabanciDil
    }
}
