using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            /*AŞAGIDAKİ GİBİ MANUEL YAZMAK YERİNE
              DİZİLER VE DÖNGÜLEREK KULLANARAK DİNAMİK ŞEKİLDE
              KULLANABİLİRİZ*/

            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);
            //Console.WriteLine(kurs4);
            //Console.WriteLine(kurs5);
            


            //Array-Dizi

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı","Programlamaya başlangıç için temel kurs","Java","python","c++"
            };


            for (int i= 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            //foreach--Dizi temelli yapıları tek tek dönmeye,dolaşmaya yarar.
            foreach (string kurs in kurslar) //kursları dolaş
            {
                Console.WriteLine(kurs);
            }
             //istege baglı for da kullanabiliriz foreach'de
             //for'u daha genel amaçlar için,foreach'i dizileri daha kolay dolaşmak için kullanırız.
            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
