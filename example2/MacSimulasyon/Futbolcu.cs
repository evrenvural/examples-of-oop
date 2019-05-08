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
    class Futbolcu
    {
        public string AdSoyad { get; set; }
        public uint FormaNo { get; set; }

        protected int hiz;
        protected int dayaniklik;
        protected int pas;
        protected int sut;
        protected int yetenek;
        protected int kararlilik;
        protected int dogalForm;
        protected int sans;
        protected Random rndm;
        

        public Futbolcu(string _adSoyad, uint _formaNo)
        {
            AdSoyad = _adSoyad;
            FormaNo = _formaNo;
            rndm = new Random();      
        }

        protected void FutbolcuDegerleriAta()
        {
            hiz = rndm.Next(50, 100);
            dayaniklik = rndm.Next(50, 100);
            pas = rndm.Next(50, 100);
            sut = rndm.Next(50, 100);
            yetenek = rndm.Next(50, 100);
            kararlilik = rndm.Next(50, 100);
            dogalForm = rndm.Next(50, 100);
            sans = rndm.Next(50, 100);
        } 

        public virtual bool PasVer()
        {
            FutbolcuDegerleriAta();

            double pasSkor = pas * 0.3 + yetenek * 0.3 + dayaniklik * 0.1 + dogalForm * 0.1 + sans * 0.2;

            // Eğer pasSkor değişkeni 60'tan büyük ise true değil ise false döner.
            return pasSkor > 60;
        }

        public virtual bool SutVur()
        {
            FutbolcuDegerleriAta();

            double golSkor = yetenek * 0.3 + sut * 0.2 + kararlilik * 0.1 + dogalForm * 0.1 + hiz * 0.1 + sans * 0.2;

            // Eğer golSkor değişkeni 70'ten büyük ise true değil ise false döner.
            return golSkor > 70;
        }

        public override string ToString()
        {
            return FormaNo + " " + AdSoyad;
        }
    }
}
