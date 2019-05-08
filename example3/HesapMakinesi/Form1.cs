using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        /****************************************************************************
        **					    SAKARYA ÜNİVERSİTESİ
        **				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
        **				   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
        **				  NESNEYE DAYALI PROGRAMLAMA DERSİ
        **					   2018-2019 BAHAR DÖNEMİ
        **	
        **				ÖDEV NUMARASI..........: 3. Ödev
        **				ÖĞRENCİ ADI............: Evren VURAL
        **				ÖĞRENCİ NUMARASI.......: G181210373
        **              DERSİN ALINDIĞI GRUP...: 2. Öğretim C Grubu
        ****************************************************************************/



        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string islem = txbIslem.Text;

            var sonuc = new DataTable().Compute(islem, null);

            lblSonuc.Text = sonuc.ToString();
        }
    }
}
