using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
{
    /****************************************************************************
**					     SAKARYA ÜNİVERSİTESİ
**				 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: EVREN VURAL
**				ÖĞRENCİ NUMARASI.......: G181210373
**              DERSİN ALINDIĞI GRUP...: 2-C
     ****************************************************************************/
    public partial class FrmCalisanBilgi : Form
    {

        private string[] satirlar;
        private string[] kelimeler;
        private int calisanSayisi;
        Calisan[] personel;

        public FrmCalisanBilgi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView.Rows.Clear();

                //Aldığı text dosyasını diziye atar.
                string dosyaYolu = openFileDialog1.FileName;
                StreamReader oku = new StreamReader(dosyaYolu, Encoding.Default);
                SinifaAktar(oku.ReadToEnd());

                //Diziden aldığı bilgileri ekrana bastırır.
                SinifiDataGrideBastir();
                btnAra.Enabled = true;
            }

        }

        private void SinifaAktar(string hepsi)
        {
            int sayac = 0;
            satirlar = hepsi.Split('\n');
            calisanSayisi = satirlar.Length;

            // Satır sayısına göre personel nesnesi oluşturur.
            personel = new Calisan[calisanSayisi];

            // Oluşturulan nesneler için hafızada yer ayırır.
            for (int i = 0; i < calisanSayisi; i++)
            {
                personel[i] = new Calisan();
            }

            // Ayrılan kelimeler oluşturulan nesnelere atanır.
            foreach (string s in satirlar)
            {
                kelimeler = s.Split(' ');

                personel[sayac].tc = kelimeler[0];
                personel[sayac].adi = kelimeler[1];
                personel[sayac].soyadi = kelimeler[2];
                personel[sayac].yas = Convert.ToInt32(kelimeler[3]);
                personel[sayac].calismaSuresi = Convert.ToInt32(kelimeler[4]);
                personel[sayac].evlilikDurumu = Convert.ToChar(kelimeler[5]);
                personel[sayac].esiCalisiyorMu = Convert.ToChar(kelimeler[6]);
                personel[sayac].cocukSayisi = Convert.ToInt32(kelimeler[7]);
                personel[sayac].tabanMaas = Convert.ToDouble(kelimeler[8]);
                personel[sayac].makamTazminati = Convert.ToDouble(kelimeler[9]);
                personel[sayac].idariGorevTazminati = Convert.ToDouble(kelimeler[10]);
                personel[sayac].fazlaMesaiSaati = Convert.ToDouble(kelimeler[11]);
                personel[sayac].fazlaMesaiSaatiUcreti = Convert.ToDouble(kelimeler[12]);
                personel[sayac].vergiMatrahi = Convert.ToDouble(kelimeler[13]);
                personel[sayac].personelFotoYolu = kelimeler[14];

                sayac++;
            }

        }

        private void SinifiDataGrideBastir()
        {
            dataGridView.Rows.Add(calisanSayisi);
            for (int i = 0; i < calisanSayisi; i++)
            {
                dataGridView.Rows[i].Cells[0].Value = personel[i].tc;
                dataGridView.Rows[i].Cells[1].Value = personel[i].adi;
                dataGridView.Rows[i].Cells[2].Value = personel[i].soyadi;
                dataGridView.Rows[i].Cells[3].Value = personel[i].yas;
                dataGridView.Rows[i].Cells[4].Value = personel[i].calismaSuresi;
                dataGridView.Rows[i].Cells[5].Value = personel[i].evlilikDurumu;
                dataGridView.Rows[i].Cells[6].Value = personel[i].esiCalisiyorMu;
                dataGridView.Rows[i].Cells[7].Value = personel[i].cocukSayisi;
                dataGridView.Rows[i].Cells[8].Value = personel[i].tabanMaas;
                dataGridView.Rows[i].Cells[9].Value = personel[i].makamTazminati;
                dataGridView.Rows[i].Cells[10].Value = personel[i].idariGorevTazminati;
                dataGridView.Rows[i].Cells[11].Value = personel[i].fazlaMesaiSaati;
                dataGridView.Rows[i].Cells[12].Value = personel[i].fazlaMesaiSaatiUcreti;
                dataGridView.Rows[i].Cells[13].Value = personel[i].vergiMatrahi;
                dataGridView.Rows[i].Cells[14].Value = personel[i].personelFotoYolu;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool bulundu = false;
            string gelenTc = txbTc.Text;
           
            //Sistemde kayıtlı personelleri tarar.
            for (int i = 0; i < calisanSayisi; i++)
            {
                //Uygun gelen tc numarasını arar.
                if (gelenTc==personel[i].tc)
                {
                    LabelVisible(true);
                   
                    //Kişisel Bilgiler
                    lblAd.Text = personel[i].adi;
                    lblSoyad.Text = personel[i].soyadi;
                    lblYas.Text = personel[i].yas.ToString();
                    lblCalismaSuresi.Text = personel[i].calismaSuresi.ToString() + " saat";
                    lblEvlilikDurumu.Text = personel[i].evlilikDurumu.ToString();
                    lblEsYasiyorMu.Text = personel[i].esiCalisiyorMu.ToString();
                    lblCocukSayisi.Text = personel[i].cocukSayisi.ToString();

                    //Maaş Bilgileri
                    lblTabanMaasi.Text = personel[i].tabanMaas.ToString() + " TL";
                    lblMakamTazminati.Text = personel[i].makamTazminati.ToString() + " TL";
                    lblIdariGorevTazminati.Text = personel[i].idariGorevTazminati.ToString() + " TL";
                    lblFazlaMesaiSaati.Text = personel[i].fazlaMesaiSaati.ToString() + " saat";
                    lblFazlaMesaiUcreti.Text = personel[i].fazlaMesaiSaatiUcreti.ToString() + " TL";
                    lblVergiMatrahı.Text = personel[i].vergiMatrahi.ToString() + " TL";
                    lblBrutMaas.Text = personel[i].BurutMaas().ToString() + " TL";
                    lblDamgaVergisi.Text = personel[i].DamgaVergisi().ToString() + " TL";
                    lblGelirVergisi.Text = personel[i].GelirVergisi().ToString() + " TL";
                    lblEmekliKesintisi.Text = personel[i].EmekliKesintisi().ToString() + " TL";
                    lblNetMaasi.Text = personel[i].NetMaas().ToString() + " TL";

                    bulundu = true;
                    break;
                }
            }
            //Eğer aranan kişi bulunamadıysa ekrana bulunamadı mesajı verir.
            if (!bulundu)
            {
                LabelVisible(false);
                MessageBox.Show("Aranan kriterde biri bulunamadı.");
            }
        }

        private void LabelVisible(bool isVisible)
        {
            lblAd.Visible = isVisible;
            lblSoyad.Visible = isVisible;
            lblYas.Visible = isVisible;
            lblCalismaSuresi.Visible = isVisible;
            lblEvlilikDurumu.Visible = isVisible;
            lblEsYasiyorMu.Visible = isVisible;
            lblCocukSayisi.Visible = isVisible;
            lblTabanMaasi.Visible = isVisible;
            lblMakamTazminati.Visible = isVisible;
            lblIdariGorevTazminati.Visible = isVisible;
            lblFazlaMesaiSaati.Visible = isVisible;
            lblFazlaMesaiUcreti.Visible = isVisible;
            lblVergiMatrahı.Visible = isVisible;
            lblBrutMaas.Visible = isVisible;
            lblDamgaVergisi.Visible = isVisible;
            lblGelirVergisi.Visible = isVisible;
            lblEmekliKesintisi.Visible = isVisible;
            lblNetMaasi.Visible = isVisible;
        }
    }
       
}
