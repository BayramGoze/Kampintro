using System;

namespace metotTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.productName = "Eksa e900 pro";
            urun1.productPrice = 182.75;
            urun1.productDescription = "Aliexpressteki en beğenilen kulaklık";
            urun1.productStock = 10;

            Product urun2 = new Product();
            urun2.productName = "Steelseries siberia kulaklık yastığı";
            urun2.productPrice = 56.95;
            urun2.productDescription = "9 cm çapı olan kulaklıklarla uyumludur";
            urun2.productStock = 27;


            Product[] urunler = new Product[] { urun1,urun2};

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.productName);
                Console.WriteLine(urun.productPrice);
                Console.WriteLine(urun.productStock);
                Console.WriteLine(urun.productDescription);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("------methots---");
            sepetManager sepetManager = new sepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);
        }
    }
}
