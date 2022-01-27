using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sayfa
{
    public abstract class Atama
    {
        /*
         * classın başına abstract yazarak şablon oluşturduk. 
        temel sınıfı abstract yaptık ve nesne oluşturamayacağımız için
        alt sınıflarını kullanan classlarla formlarda polymorphism ile çağırdık.
        */

        //Fiyat değişkeni formlardan gelen fiyat bilgilerini tutması için oluşturuldu.
        public int Fiyat;
        public  String x;
        public  String y;
        public  String z;
        public  String t;
        public  String k;

        public static string kategori;
        public static string isim;

        public Atama()
        {
            //Şehirlere göre para birimleri formlarda atama yapılarak kullanıldı.
            x = "TL";
            y = "Euro";
            z = "Ars";
            t = "Kron";
            k = "Yen";

        }

      

        //metotun başına abstract yazarak gövdesi hesap metotu oluşturduk.
        // Atama sınıfından miras alan sınıflarda da hesap metodunu implement ederiz.
        //Ve her classın kendi hesap fonksiyonu çalışmış oldu.
        public abstract int Hesap();




    }

}
