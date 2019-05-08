using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacSimulasyon
{
    class Defans : Futbolcu
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

        int pozisyonAlma;
        int kafa;
        int sicrama;
        public Defans(string _adSoyad, uint _formaNo) : base(_adSoyad, _formaNo)
        {
            
        }

        private void DefansDegerleriAta()
        {
            pozisyonAlma = rndm.Next(50, 90);
            kafa = rndm.Next(50, 90);
            sicrama = rndm.Next(50, 90);
        }

        public override bool PasVer()
        {
            FutbolcuDegerleriAta();
            DefansDegerleriAta();

            double pasSkor = pas * 0.3 + yetenek * 0.3 + dayaniklik * 0.1 + dogalForm * 0.1 + pozisyonAlma * 0.1 + sans * 0.2;

            // Eğer pasSkor değişkeni 60'tan büyük ise true değil ise false döner.
            return pasSkor > 60;
        }

        public override bool SutVur()
        {
            FutbolcuDegerleriAta();
            DefansDegerleriAta();

            double golSkor = yetenek * 0.3 + sut * 0.2 + kararlilik * 0.1 + dogalForm * 0.1 + kafa * 0.1 + sicrama * 0.1 + sans * 0.1;

            // Eğer golSkor değişkeni 70'ten büyük ise true değil ise false döner.
            return golSkor > 70;
        }

    }
}
