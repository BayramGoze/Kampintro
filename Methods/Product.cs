using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product //ürün
    {
        //PROPERTY-ÖZELLİKLER. ÖR;BİR MÜŞTERİNİN BİLGİLERİNİ TUTMAK
        public int Id { get; set; }//ID bir datayı digerlerinden ayırt etmek ıcın kullandıgımız eşşiz degeri anlatır. 
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
