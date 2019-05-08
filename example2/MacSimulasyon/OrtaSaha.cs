using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacSimulasyon
{
    class OrtaSaha : Futbolcu
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

        int uzunTop;
        int ilkDokunus;
        int uretkenlik;
        int topSurme;
        int ozelYetenek;
        public OrtaSaha(string _adSoyad, uint _formaNo) : base(_adSoyad, _formaNo)
        {
           
        }

        private void OrtaSahaDegerleriAta()
        {
            uzunTop = rndm.Next(60, 100);
            ilkDokunus = rndm.Next(60, 100);
            uretkenlik = rndm.Next(60, 100);
            topSurme = rndm.Next(60, 100);
            ozelYetenek = rndm.Next(60, 100);
        }

        public override bool PasVer()
        {
            FutbolcuDegerleriAta();
            OrtaSahaDegerleriAta();

            double pasSkor = pas * 0.3 + yetenek * 0.2 + ozelYetenek * 0.2 + dayaniklik * 0.1 + dogalForm * 0.1 + uzunTop * 0.1 + topSurme * 0.1 + sans * 0.1;

            // Eğer pasSkor değişkeni 60'tan büyük ise true değil ise false döner.
            return pasSkor > 60;
        }

        public override bool SutVur()
        {
            FutbolcuDegerleriAta();
            OrtaSahaDegerleriAta();

            double golSkor = yetenek * 0.3 + ozelYetenek * 0.2 + sut * 0.2 + ilkDokunus * 0.1 + kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.1;

            // Eğer golSkor değişkeni 70'ten büyük ise true değil ise false döner.
            return golSkor > 70;
        }
    }
}
