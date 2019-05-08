using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HayvanCiftligi
{
    /****************************************************************************
**					     SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: EVREN VURAL
**				ÖĞRENCİ NUMARASI.......: G181210373
**              DERSİN ALINDIĞI GRUP...: 2-C
****************************************************************************/

    class Keci : Hayvan
    {
        public int Sut { get; private set; }

        public Keci()
        {
            Sut = 0;
            Enerji = 100;
            birimFiyati = 8;

            ses = new SoundPlayer(HayvanCiftligi.Properties.Resources.keci);
        }

        public void SutSag()
        {
            // Eğer keçi Ölmediyse süt sağılabilir.
            if (!OlduMu())
            {
                Sut++;
            }
        }

        public override void EnerjiAzalt()
        {
            Enerji -= 6;
        }

        public override void SesCikar()
        {
            ses.Play();
        }

        public override int UrunSat()
        {
            int urunFiyati = Sut * birimFiyati;
            Sut = 0;

            return urunFiyati;
        }
    }
}

