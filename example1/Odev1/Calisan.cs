using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    /****************************************************************************
**					     SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: EVREN VURAL
**				ÖĞRENCİ NUMARASI.......: G181210373
**              DERSİN ALINDIĞI GRUP...: 2-C
     ****************************************************************************/
    class Calisan
    {
        public string tc;
        public string adi;
        public string soyadi;
        public int yas;
        public int calismaSuresi;
        public char evlilikDurumu;
        public char esiCalisiyorMu;
        public int cocukSayisi;
        public double tabanMaas;
        public double makamTazminati;
        public double idariGorevTazminati;
        public double fazlaMesaiSaati;
        public double fazlaMesaiSaatiUcreti;
        public double vergiMatrahi;
        public string personelFotoYolu;

        public double BurutMaas()
        {
            //Bekarsa
            if (evlilikDurumu == 'B')
            {
                return tabanMaas + makamTazminati + idariGorevTazminati + cocukSayisi * 30 + fazlaMesaiSaati * fazlaMesaiSaatiUcreti;
            }
            //Evliyse ve eşi çalışıyorsa
            else if (evlilikDurumu == 'E' && esiCalisiyorMu == 'E')
            {
                return tabanMaas + makamTazminati + idariGorevTazminati + cocukSayisi * 30 + fazlaMesaiSaati * fazlaMesaiSaatiUcreti;
            }
            //Evliyse ve eşi çalışmıyorsa
            else
            {
                return tabanMaas + makamTazminati + idariGorevTazminati + 200 + cocukSayisi * 30 + fazlaMesaiSaati * fazlaMesaiSaatiUcreti;
            }
        }
        public double DamgaVergisi()
        {
            return BurutMaas() * 10 / 100;
        }
        public double GelirVergisi()
        {
            // Eğer gelir matrahı 10000 TL den küçük ise
            if (vergiMatrahi < 10000)
            {
                return BurutMaas() * 15 / 100;
            }
            // Eğer gelir matrahı  10000 TL den büyük eşit ve 20000 TL küçük ise
            else if (vergiMatrahi >= 10000 && vergiMatrahi < 20000)
            {
                return BurutMaas() * 20 / 100;
            }
            // Eğer gelir matrahı  20000 TL den büyük eşit ve 30000 TL küçük ise  
            else if (vergiMatrahi >= 20000 && vergiMatrahi < 30000)
            {
                return BurutMaas() * 25 / 100;
            }
            // Eğer gelir matrahı  30000 TL den büyük eşit ise
            else
            {
                return BurutMaas() * 30 / 100;

            }
        }
        public double EmekliKesintisi()
        {
            return BurutMaas() * 15 / 100;
        }
        public double NetMaas()
        {
            return BurutMaas() - (EmekliKesintisi() + GelirVergisi() + DamgaVergisi());
        }

    }

}
