using System;

namespace calısmaSayfam
{
    class Program
    {
        static void Main(string[] args)
        {
            DersProgramı pazartesi = new DersProgramı();

            pazartesi.DersAdı = "Türk İdare Tarihi";
            pazartesi.Ögretmen = "Alpay Hoca";
            pazartesi.DersSaati = 3;
            Console.WriteLine("------------------");

            DersProgramı salı = new DersProgramı();

            salı.DersAdı = "Siyaset Bilimi";
            salı.Ögretmen = "Faruk Hoca";
            salı.DersSaati = 3;

            DersProgramı çarsamba = new DersProgramı();

            çarsamba.DersAdı = "Yönetim Psikolojisi";
            çarsamba.Ögretmen = "Caner Hoca";
            çarsamba.DersSaati = 2;

            DersProgramı[] dersler = new DersProgramı[]
            {
                pazartesi,salı,çarsamba
            };
            foreach (DersProgramı ders in dersler)
            {
                Console.WriteLine(ders.DersAdı+ " : " +ders.Ögretmen+" : " + ders.DersSaati+"saat");
            }
            Console.ReadKey();

        }
       class DersProgramı
        {
            public string DersAdı { get; set; }
            public string Ögretmen { get; set; }
            public int DersSaati { get; set; }
        }
            
    }
}
