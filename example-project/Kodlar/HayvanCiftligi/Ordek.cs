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

    class Ordek : Hayvan
    {
        public int Yumurta { get; private set; }

        public Ordek()
        {
            Yumurta = 0;
            Enerji = 100;
            birimFiyati = 3;

            ses = new SoundPlayer(HayvanCiftligi.Properties.Resources.ordek);
        }

        public void Yumurtla()
        {
            // Eğer ördek Ölmediyse yumurtlayabilir.
            if (!OlduMu())
            {
                Yumurta++;
            }
        }

        public override void EnerjiAzalt()
        {
            Enerji -= 3;
        }

        public override void SesCikar()
        {
            ses.Play();
        }

        public override int UrunSat()
        {
            int urunFiyati = Yumurta * birimFiyati;
            Yumurta = 0;

            return urunFiyati;
        }
    }
}

