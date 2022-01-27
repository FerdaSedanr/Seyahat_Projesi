using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sayfa
{   // interface kodları
    //Sınıf(Class) içinde kullanılacak olan property tanımlaması yaptık
   
    interface IYemekSatis
    {
        int YemekFiyat { get; set; }
        int KisiAdet { get; set; }
        int YSonucu { get; set; }
        string Yad { get; set; }
        string Ybolge { get; set; }
        string Ykhv { get; set; }
        string Yögley { get; set; }
        string Yaksmy { get; set; }
        string Yaprtf { get; set; }
        string Ytatlı { get; set; }
    }
}
