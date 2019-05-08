using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

namespace HayvanCiftligi
{
    public partial class frmHayvanCiftligi : Form
    {
        Tavuk tavuk; Ordek ordek; Inek inek; Keci keci;
        bool birKereTavuk, birKereOrdek, birKereInek, birKereKeci;
        int saniye;
        int kasa;
        public frmHayvanCiftligi()
        {
            InitializeComponent();
        }
        private void frmHayvanCiftligi_Load(object sender, EventArgs e)
        {
            tavuk = new Tavuk();
            ordek = new Ordek();
            inek = new Inek();
            keci = new Keci();

            birKereTavuk = true;
            birKereOrdek = true;
            birKereInek = true;
            birKereKeci = true;

            timer.Enabled = true;
            update.Enabled = true;

            saniye = 0;
            kasa = 0;
        }

        private void btnTavukSat_Click(object sender, EventArgs e)
        {
            kasa += tavuk.UrunSat();
        }

        private void btnOrdekSat_Click(object sender, EventArgs e)
        {
            kasa += ordek.UrunSat();
        }

        private void btnInekSat_Click(object sender, EventArgs e)
        {
            kasa += inek.UrunSat();
        }

        private void btnKeciSat_Click(object sender, EventArgs e)
        {
            kasa += keci.UrunSat();
        }

        private void btnTavukYem_Click(object sender, EventArgs e)
        {
            tavuk.YemVer();
        }

        private void btnOrdekYem_Click(object sender, EventArgs e)
        {
            ordek.YemVer();
        }

        private void btnInekYem_Click(object sender, EventArgs e)
        {
            inek.YemVer();
        }

        private void btnKeciYem_Click(object sender, EventArgs e)
        {
            keci.YemVer();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            saniye++;
            
            // Her saniyede bir hayvanların enerjileri kendi dayanıklıklarına göre düşer.
            tavuk.EnerjiAzalt();
            ordek.EnerjiAzalt();
            inek.EnerjiAzalt();
            keci.EnerjiAzalt();

            // Geçen süre label'a yazılır.
            lblSaniye.Text = saniye + " SN";

            // Hayvanların ölme durumları
            if (tavuk.OlduMu() && birKereTavuk)
            {
                lblTavukCan.Text = "ÖLDÜ";
                tavuk.SesCikar();
                birKereTavuk = false;
            }
            if (ordek.OlduMu() && birKereOrdek)
            {
                lblOrdekCan.Text = "ÖLDÜ";
                ordek.SesCikar();
                birKereOrdek = false;
            }
            if (inek.OlduMu() && birKereInek)
            {
                lblInekCan.Text = "ÖLDÜ";
                inek.SesCikar();
                birKereInek = false;
            }
            if (keci.OlduMu() && birKereKeci)
            {
                lblKeciCan.Text = "ÖLDÜ";
                keci.SesCikar();
                birKereKeci = false;
            }

            // Hayvanların saniyede bir ürün üretme durumları
            if (saniye % 3 == 0)
            {
                tavuk.Yumurtla();
            }
            if (saniye % 5 == 0)
            {
                ordek.Yumurtla();
            }
            if (saniye % 8 == 0)
            {
                inek.SutSag();
            }
            if (saniye % 7 == 0)
            {
                keci.SutSag();
            }
        }

        private void update_Tick(object sender, EventArgs e)
        {
            // Hayvanların enerjileri progress bara atanır.
            prgBarTavuk.Value = tavuk.Enerji;
            prgBarOrdek.Value = ordek.Enerji;
            prgBarInek.Value = inek.Enerji;
            prgBarKeci.Value = keci.Enerji;

            // Ürün Deposu labelları yazılır.
            lblTavukAdet.Text = tavuk.Yumurta + " ADET";
            lblOrdekAdet.Text = ordek.Yumurta + " ADET";
            lblInekAdet.Text = inek.Sut + " KG";
            lblKeciAdet.Text = keci.Sut + " KG";

            // Kasa değişkeni ekrana yazılır.
            lblPara.Text = kasa + " TL";
        }
    }
}
