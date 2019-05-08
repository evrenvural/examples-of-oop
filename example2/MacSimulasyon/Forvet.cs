using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacSimulasyon
{
    class Forvet : Futbolcu
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

        int bitiricilik;
        int ilkDokunus;
        int kafa;
        int ozelYetenek;
        int sogukkanlilik;

        public Forvet(string _adSoyad, uint _formaNo) : base(_adSoyad, _formaNo)
        {
           
        }

        private void ForvetDegerleriAta()
        {
            bitiricilik = rndm.Next(70, 100);
            ilkDokunus = rndm.Next(70, 100);
            kafa = rndm.Next(70, 100);
            ozelYetenek = rndm.Next(70, 100);
            sogukkanlilik = rndm.Next(70, 100);
        }

        public override bool PasVer()
        {
            FutbolcuDegerleriAta();
            ForvetDegerleriAta();

            double pasSkor = pas * 0.3 + yetenek * 0.2 + ozelYetenek * 0.2 + dayaniklik * 0.1 + dogalForm * 0.1 + sans * 0.1;

            // Eğer pasSkor değişkeni 60'tan büyük ise true değil ise false döner.
            return pasSkor > 60;
        }

        public override bool SutVur()
        {
            FutbolcuDegerleriAta();
            ForvetDegerleriAta();

            double golSkor = yetenek * 0.2 + ozelYetenek * 0.2 + sut * 0.1 + kafa * 0.1 + ilkDokunus * 0.1 + bitiricilik * 0.1 + sogukkanlilik * 0.1 + kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.1;

            // Eğer golSkor değişkeni 70'ten büyük ise true değil ise false döner.
            return golSkor > 70;
        }
    }
}
