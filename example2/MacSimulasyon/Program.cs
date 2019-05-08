using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacSimulasyon
{
    /****************************************************************************
**					     SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: EVREN VURAL
**				ÖĞRENCİ NUMARASI.......: G181210373
**              DERSİN ALINDIĞI GRUP...: 2-C
 ****************************************************************************/
    class Program
    {
        static List<Futbolcu> takim;
        static int sonSayi = 55;
        static int sayi;
        static int pasSayisi;
        static void Main(string[] args)
        {
            Spiker spiker = new Spiker(ConsoleColor.White, ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.Green, ConsoleColor.DarkRed);

            takim = new List<Futbolcu>();
            takim.Add(new Defans("Nagatomo", 2)); 
            takim.Add(new Defans("Ozan Kabak", 3)); 
            takim.Add(new Defans("Luyindama", 4)); 
            takim.Add(new Defans("Mariano", 5)); 
            takim.Add(new OrtaSaha("Felipe Melo", 6)); 
            takim.Add(new OrtaSaha("Amrabat", 7)); 
            takim.Add(new OrtaSaha("Suat Kaya", 8)); 
            takim.Add(new Forvet("Didier Drogba", 9));
            takim.Add(new Forvet("Sneijder", 10));
            takim.Add(new OrtaSaha("Harry Kewell", 11));

            Console.WriteLine(spiker.MacBasi());
            Console.WriteLine();
            Console.WriteLine("Press enter to start the match");
            Console.ReadLine();
            Console.Clear();

            Futbolcu secilenOyuncu;
            do
            {
                // Son pas verilen oyuncunun şutu gol olmadığı sürece devam eder.
                pasSayisi = 0;
                do
                {
                    // Toplam 3 başarılı pas yapılana kadar devam eder.
                    secilenOyuncu = OyuncuSec();

                    Console.Write(spiker.Atak(secilenOyuncu.ToString()));
                    Console.ReadLine();

                    if (secilenOyuncu.PasVer())
                    {
                        // Eğer seçilen oyuncu başarılı pas verirse bu bloğa girilir.
                        pasSayisi++;
                        Console.WriteLine(spiker.Pas());
                    }
                    else
                    {
                        pasSayisi = 0;
                        Console.WriteLine(spiker.TopKaybi());
                    }

                } while (pasSayisi < 3);

                secilenOyuncu = OyuncuSec();

                Console.WriteLine(spiker.Sut(secilenOyuncu.ToString()));
                Console.ReadLine();

                if (secilenOyuncu.SutVur())
                {
                    // Eğer son pas verilen oyuncunun şutu gol olursa bu bloğa girilir. 
                    Console.WriteLine(spiker.Gol() + " " + secilenOyuncu);
                }
                else
                {
                    Console.WriteLine(spiker.SutKacti());
                }

                Console.ReadLine();
            } while (!secilenOyuncu.SutVur());

            
        }

        static Futbolcu OyuncuSec()
        {
            Random rndm = new Random();

            do
            {
                // Daha önce üretilen rastgele sayı ile şu an üretilen eğer aynı ise farklı olana kadar yeni sayı üretilir.
                sayi = rndm.Next(0, 10);
            } while (sonSayi == sayi);

            sonSayi = sayi;

            return takim[sayi];
        }
    }
}
