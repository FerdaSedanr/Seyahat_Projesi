using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{
    public class Sepet
    {
        // İçerisinde gönderilen nesneleri listeleyerek tutulmasını sağlıyor.
        private List<Atama> yeni = new List<Atama>();

        // Formlardan gelen nesneleri yeni listesine kaydeden metot.
        public void Add(Atama hesap)
        {
            if (hesap != null)
            {
                yeni.Add(hesap);
            }
        }

        // Yeni listesindeki bilgileri döndürür.
        public List<Atama> GetAtama()
        {
            return yeni;
        }

        public  Sepet() {

        }

        //gelen bilgileri formda yazdırmak için değişkenler oluşturuldu.
        public static String isim, müzeisim, turisim, restoranisim, ulasimisim;
        public String sonuç, click1, click2, click3, click4, click5;

        /*
         * Odeme formundaki bilgilerin başka forma geçerken
         * sabit kalması için fiyatlar ilk değeri static olarak 0' atandı. 
         */
        public static String kisisayisi = "0";
        public static String kisisayisimüze = "0";
        public static String kisisayisitur = "0";
        public static String kisisayisirestoran = "0";
        public static String kisisayisiulaşım = "0";


        public static String günlükfiyatmüze = "0";
        public static String günlükfiyattur = "0";
        public static String günlükfiyatrestoran = "0";
        public static String günlükfiyati = "0";
        public static String fiyatulaşım= "0";


        public static String müzetoplam = "0";
        public static String turtoplam = "0";
        public static String restorantoplam = "0";
        public static String oteltoplam = "0";
        public static String ulaşımtoplam = "0";


        public static int günsayisi = 0;
        public static int günsayisitur = 0;
        public String birim;
        public static double total;


        // Total Fiyatı tutmak için değişken oluşturuldu.
        public static double totalPrice = 0;

        // Total Fiyatı hesaplar ve döndürür. 
        public double TotalPrice()
        {

            foreach (var toplam in yeni)
            {
                 totalPrice += toplam.Fiyat;
            }
            return totalPrice;
        }

    }
}

