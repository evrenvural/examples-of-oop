using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacSimulasyon
{
    class Spiker
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

        private ConsoleColor arkaPlanRengi;
        private ConsoleColor yaziRengi;
        private ConsoleColor olumluYaziRengi;
        private ConsoleColor olumsuzYaziRengi;
        private ConsoleColor spikerRengi;
        private Random rndm;

        public Spiker(ConsoleColor _arkaPlanRengi, ConsoleColor _yaziRengi, ConsoleColor _spikerRengi, ConsoleColor _olumluYaziRengi, ConsoleColor _olumsuzYaziRengi)
        {
            Console.BackgroundColor = _arkaPlanRengi;
            Console.ForegroundColor = _yaziRengi;
            Console.Clear();

            arkaPlanRengi = _arkaPlanRengi;
            yaziRengi = _yaziRengi;
            olumluYaziRengi = _olumluYaziRengi;
            olumsuzYaziRengi = _olumsuzYaziRengi;
            spikerRengi = _spikerRengi;

            rndm = new Random();
        }

        public string MacBasi()
        {
            SpikerYazdir();
            Console.ForegroundColor = yaziRengi;

            string[] macBaslayacak = new string[3];
            macBaslayacak[0] = "We are together for awesome the match";
            macBaslayacak[1] = "Have a perfect weather today for football";
            macBaslayacak[2] = "Referee's checking his watch";

            return macBaslayacak[rndm.Next(0,3)];
        }
        public string Atak(string futbolcuIsmi)
        {
            SpikerYazdir();
            string[] atak = new string[3];

            atak[0] = " atacks from the right";
            atak[1] = " plays effective";
            atak[2] = " atacks from the left";
            
            Console.ForegroundColor = yaziRengi;

            return futbolcuIsmi + atak[rndm.Next(0,3)];
        }
        public string Gol()
        {
            SpikerYazdir();
            string[] gol = new string[3];

            gol[0] = "Goalllllllll";
            gol[1] = "Excellent shoot and perfect goal!";
            gol[2] = "What a goal!";
            
            Console.ForegroundColor = olumluYaziRengi;

            return gol[rndm.Next(0, 3)];
        }
        public string Pas()
        {
            SpikerYazdir();
            Console.ForegroundColor = olumluYaziRengi;

            string[] pas = new string[2];

            pas[0] = "Perfect pass";
            pas[1] = "Good pass";
            
            return pas[rndm.Next(0, 2)];
        }
        public string TopKaybi()
        {
            SpikerYazdir();
            string[] kaptiriyor = new string[3];

            kaptiriyor[0] = "Defence is doing a good job tonight";
            kaptiriyor[1] = "And.. out";
            kaptiriyor[2] = "Ball Loss";
            
            Console.ForegroundColor = olumsuzYaziRengi;

            return kaptiriyor[rndm.Next(0,3)];
        }
        public string Sut(string futbolcuIsmi)
        {
            SpikerYazdir();
            string sut = " shoots...";

            Console.ForegroundColor = yaziRengi;

            return futbolcuIsmi + sut;
        }
        public string SutKacti()
        {
            SpikerYazdir();
            string[] kacti = new string[2];

            kacti[0] = "Too weak shoot";
            kacti[1] = "Missed...";
            
            Console.ForegroundColor = olumsuzYaziRengi;

            return kacti[rndm.Next(0,2)];
        }

        private void SpikerYazdir()
        {
            Console.ForegroundColor = spikerRengi;
            Console.Write("Commentary: ");
        }
    }
}
