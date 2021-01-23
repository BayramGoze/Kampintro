using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager  //classın sonunda menager,services,controller vb. ifadeler varsa bunlar bir operasyon tutuyor demek.
    {
        //naming convention--isimlendirme kuralı
        //syntax

        //METHOD YAZIMI
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}



//ör;ALısveris sistemindeki sepete ekleme,sepeti gösterme-listeleme gibi işlemleri method olarak gruplandırabiliriz.