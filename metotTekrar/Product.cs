using System;
using System.Collections.Generic;
using System.Text;

namespace metotTekrar
{
    class Product
    {
        public int Id { get; set; }
        public string  productName { get; set; }
        public double productPrice { get; set; }
        public string productDescription{ get; set; }
        public int productStock { get; set; }

    }
    class sepetManager
    {
        public void ekle(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi!"+" : " + urun.productName);
        }
    }
}
