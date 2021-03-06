using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sayfa
{

    public enum TurIsmi
    {
        AKTUR ,
        ULUTUR ,
        ÖZTUR ,
        CANTUR ,

        BIGTOUR ,
        TRIOTOUR ,
        REDTOUR ,
        ASIATOUR ,

        ASIANTOUR,
        IKURATOUR,
        ARIGATOUR,
        AWARETOUR,

    }
    public class TurSehir : Atama
    {
        // labellar 

        public String m1 = "TUR TERCİHLERİ";
        public String m3 = "Bütçeye Göre Sırala";
        public String m4 = "Kişi Sayısı";
        public String m5 = "Tura Katılım Tarihi";
        public String m6 = "Başlangıç:";
        public String m7 = "Bitiş:";

        // butonlar

        public String b1 = "Uygula";
        public String b2 = "Seçimi Temizle";
        public String b3 = "Ödeme";

        // özellikler

        public String o1 = "Her Şey Dahil";
        public String o2 = "Rehber";
        public String o3 = "Gidiş Dönüş";


        public TurSehir()
        {

        }

        public String a = Atama.isim;

        public String tur;
        public int turfiyat;
        public int turkisisayisi;
        public int turgun;

        public int toplamt;
        public void gonder(string isimtur, int fiyattur, int kisitur, int timetur)
        {
            this.tur = isimtur;
            this.turfiyat = fiyattur;
            this.turkisisayisi = kisitur;
            this.turgun=timetur;
        }


        public void Fiyatlandırma(TurIsmi isim)
        {
            
            switch (isim)
            {
                    
                case TurIsmi.AKTUR:  // Türkiye için AKTUR,ULUTUR,ÖZTÜR ve CANTUR isimleri kullandım
                case TurIsmi.BIGTOUR: //Y urt dışı için BIGTOUR,TRIOTOUR,REDTOUR ve ASIATOUR isimlerini kullandım.
                    this.Fiyat = 600;
                    break;

                case TurIsmi.ULUTUR:
                case TurIsmi.TRIOTOUR:
                    this.Fiyat = 1200;
                    break;

                case TurIsmi.ÖZTUR:
                case TurIsmi.REDTOUR:  
                    this.Fiyat = 2000;
                    break;

                case TurIsmi.CANTUR:
                case TurIsmi.ASIATOUR:
                    this.Fiyat = 2800;
                    break;

                case TurIsmi.ASIANTOUR: // Bu tur isimleri para biriminde çok sıfır oldugu icin japonyaya ait ayırmam gerekliydi.
                    this.Fiyat = 600000; // ASIANTOUR,IKURATOUT,ARIGATOUR ve AWARETOUR
                    break;

                case TurIsmi.IKURATOUR:
                    this.Fiyat = 1200000;
                    break;

                case TurIsmi.ARIGATOUR:
                    // thıs.ısım = fujı dagı
                    // kara orman falan fılan
                    this.Fiyat = 200000;
                    break;

                case TurIsmi.AWARETOUR:
                    this.Fiyat = 2800000;
                    break;

            }
        }
       
        // Formdan gelen bilgilerle ücret hesaplayan bir fonksiyon
        public override int Hesap()
        {
            toplamt = turfiyat * turkisisayisi * turgun;
            return toplamt;
        }

    } 
}