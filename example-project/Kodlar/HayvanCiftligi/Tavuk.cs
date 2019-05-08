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

    class Tavuk : Hayvan
    {
        public int Yumurta { get; private set; }

        public Tavuk()
        {
            Yumurta = 0;
            Enerji = 100;
            birimFiyati = 1;

            ses = new SoundPlayer(HayvanCiftligi.Properties.Resources.tavuk);
        }

        public void Yumurtla()
        {
            // Eğer tavuk Ölmediyse yumurtlayabilir.
            if (!OlduMu())
            {
                Yumurta++;
            }
        }

        public override void EnerjiAzalt()
        {
            Enerji -= 2;
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
