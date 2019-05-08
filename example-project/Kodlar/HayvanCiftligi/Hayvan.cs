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

    abstract class Hayvan
    {
        protected SoundPlayer ses;
        protected int birimFiyati;

        private int _enerji;
        public int Enerji
        {
            get { return _enerji; }
            protected set
            {
                if (value <= 0)
                {
                    _enerji = 0;
                }
                else
                {
                    _enerji = value;
                }
            }
        }

        public bool OlduMu()
        {
            return Enerji <= 0;
        }

        public void YemVer()
        {
            // Eğer hayvan ölmediyse yem verilebilir.
            if (!OlduMu())
            {
                Enerji = 100;
            }
        }

        public abstract void EnerjiAzalt();

        public abstract void SesCikar();

        public abstract int UrunSat();
    }
}
