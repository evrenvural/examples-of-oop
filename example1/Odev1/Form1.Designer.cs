namespace Odev1
{
    partial class FrmCalisanBilgi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNetMaasi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmekliKesintisi = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGelirVergisi = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDamgaVergisi = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblBrutMaas = new System.Windows.Forms.Label();
            this.label323 = new System.Windows.Forms.Label();
            this.lblVergiMatrahı = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFazlaMesaiUcreti = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFazlaMesaiSaati = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblIdariGorevTazminati = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblMakamTazminati = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTabanMaasi = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCocukSayisi = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEsYasiyorMu = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblEvlilikDurumu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCalismaSuresi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(26, 80);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(68, 30);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridView.Location = new System.Drawing.Point(114, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1321, 151);
            this.dataGridView.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Yaş";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Çalışma Süresi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Evlilik Durumu";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Eş Yaşıyor Mu? ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Çocuk Sayısı";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Taban Maaş";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Makam Tazminatı";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "İdari Görev Tazminatı";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Fazla Mesai Saati";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Fazla Mesai Saat Ücreti";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Vergi Matrahı";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Personel Resmi Yolu";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(17, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1366, 420);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNetMaasi);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblEmekliKesintisi);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblGelirVergisi);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.lblDamgaVergisi);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.lblBrutMaas);
            this.groupBox3.Controls.Add(this.label323);
            this.groupBox3.Controls.Add(this.lblVergiMatrahı);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblFazlaMesaiUcreti);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblFazlaMesaiSaati);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblIdariGorevTazminati);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.lblMakamTazminati);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.lblTabanMaasi);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(579, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 323);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Maaş Bilgileri";
            // 
            // lblNetMaasi
            // 
            this.lblNetMaasi.AutoSize = true;
            this.lblNetMaasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNetMaasi.Location = new System.Drawing.Point(484, 262);
            this.lblNetMaasi.Name = "lblNetMaasi";
            this.lblNetMaasi.Size = new System.Drawing.Size(24, 15);
            this.lblNetMaasi.TabIndex = 21;
            this.lblNetMaasi.Text = "Ad:";
            this.lblNetMaasi.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(304, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Net Maaşı:";
            // 
            // lblEmekliKesintisi
            // 
            this.lblEmekliKesintisi.AutoSize = true;
            this.lblEmekliKesintisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmekliKesintisi.Location = new System.Drawing.Point(484, 208);
            this.lblEmekliKesintisi.Name = "lblEmekliKesintisi";
            this.lblEmekliKesintisi.Size = new System.Drawing.Size(24, 15);
            this.lblEmekliKesintisi.TabIndex = 19;
            this.lblEmekliKesintisi.Text = "Ad:";
            this.lblEmekliKesintisi.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(304, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Emekli Kesintisi:";
            // 
            // lblGelirVergisi
            // 
            this.lblGelirVergisi.AutoSize = true;
            this.lblGelirVergisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelirVergisi.Location = new System.Drawing.Point(484, 137);
            this.lblGelirVergisi.Name = "lblGelirVergisi";
            this.lblGelirVergisi.Size = new System.Drawing.Size(24, 15);
            this.lblGelirVergisi.TabIndex = 17;
            this.lblGelirVergisi.Text = "Ad:";
            this.lblGelirVergisi.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(304, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 15);
            this.label19.TabIndex = 16;
            this.label19.Text = "Gelir Vergisi:";
            // 
            // lblDamgaVergisi
            // 
            this.lblDamgaVergisi.AutoSize = true;
            this.lblDamgaVergisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDamgaVergisi.Location = new System.Drawing.Point(484, 68);
            this.lblDamgaVergisi.Name = "lblDamgaVergisi";
            this.lblDamgaVergisi.Size = new System.Drawing.Size(24, 15);
            this.lblDamgaVergisi.TabIndex = 15;
            this.lblDamgaVergisi.Text = "Ad:";
            this.lblDamgaVergisi.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(304, 68);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 15);
            this.label23.TabIndex = 14;
            this.label23.Text = "Damga Vergisi:";
            // 
            // lblBrutMaas
            // 
            this.lblBrutMaas.AutoSize = true;
            this.lblBrutMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrutMaas.Location = new System.Drawing.Point(679, 208);
            this.lblBrutMaas.Name = "lblBrutMaas";
            this.lblBrutMaas.Size = new System.Drawing.Size(24, 15);
            this.lblBrutMaas.TabIndex = 13;
            this.lblBrutMaas.Text = "Ad:";
            this.lblBrutMaas.Visible = false;
            // 
            // label323
            // 
            this.label323.AutoSize = true;
            this.label323.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label323.Location = new System.Drawing.Point(561, 208);
            this.label323.Name = "label323";
            this.label323.Size = new System.Drawing.Size(66, 15);
            this.label323.TabIndex = 12;
            this.label323.Text = "Brüt Maaş:";
            // 
            // lblVergiMatrahı
            // 
            this.lblVergiMatrahı.AutoSize = true;
            this.lblVergiMatrahı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVergiMatrahı.Location = new System.Drawing.Point(679, 68);
            this.lblVergiMatrahı.Name = "lblVergiMatrahı";
            this.lblVergiMatrahı.Size = new System.Drawing.Size(24, 15);
            this.lblVergiMatrahı.TabIndex = 11;
            this.lblVergiMatrahı.Text = "Ad:";
            this.lblVergiMatrahı.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(561, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Vergi Matrahı:";
            // 
            // lblFazlaMesaiUcreti
            // 
            this.lblFazlaMesaiUcreti.AutoSize = true;
            this.lblFazlaMesaiUcreti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFazlaMesaiUcreti.Location = new System.Drawing.Point(679, 137);
            this.lblFazlaMesaiUcreti.Name = "lblFazlaMesaiUcreti";
            this.lblFazlaMesaiUcreti.Size = new System.Drawing.Size(24, 15);
            this.lblFazlaMesaiUcreti.TabIndex = 9;
            this.lblFazlaMesaiUcreti.Text = "Ad:";
            this.lblFazlaMesaiUcreti.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(561, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Fazla Mesai Ücreti:";
            // 
            // lblFazlaMesaiSaati
            // 
            this.lblFazlaMesaiSaati.AutoSize = true;
            this.lblFazlaMesaiSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFazlaMesaiSaati.Location = new System.Drawing.Point(228, 262);
            this.lblFazlaMesaiSaati.Name = "lblFazlaMesaiSaati";
            this.lblFazlaMesaiSaati.Size = new System.Drawing.Size(24, 15);
            this.lblFazlaMesaiSaati.TabIndex = 7;
            this.lblFazlaMesaiSaati.Text = "Ad:";
            this.lblFazlaMesaiSaati.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(48, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Fazla Mesai Saati:";
            // 
            // lblIdariGorevTazminati
            // 
            this.lblIdariGorevTazminati.AutoSize = true;
            this.lblIdariGorevTazminati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdariGorevTazminati.Location = new System.Drawing.Point(228, 208);
            this.lblIdariGorevTazminati.Name = "lblIdariGorevTazminati";
            this.lblIdariGorevTazminati.Size = new System.Drawing.Size(24, 15);
            this.lblIdariGorevTazminati.TabIndex = 5;
            this.lblIdariGorevTazminati.Text = "Ad:";
            this.lblIdariGorevTazminati.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(48, 208);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 15);
            this.label18.TabIndex = 4;
            this.label18.Text = "İdari Görev Tazminatı:";
            // 
            // lblMakamTazminati
            // 
            this.lblMakamTazminati.AutoSize = true;
            this.lblMakamTazminati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMakamTazminati.Location = new System.Drawing.Point(228, 137);
            this.lblMakamTazminati.Name = "lblMakamTazminati";
            this.lblMakamTazminati.Size = new System.Drawing.Size(24, 15);
            this.lblMakamTazminati.TabIndex = 3;
            this.lblMakamTazminati.Text = "Ad:";
            this.lblMakamTazminati.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(48, 137);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 15);
            this.label20.TabIndex = 2;
            this.label20.Text = "Makam Tazminatı:";
            // 
            // lblTabanMaasi
            // 
            this.lblTabanMaasi.AutoSize = true;
            this.lblTabanMaasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTabanMaasi.Location = new System.Drawing.Point(228, 68);
            this.lblTabanMaasi.Name = "lblTabanMaasi";
            this.lblTabanMaasi.Size = new System.Drawing.Size(24, 15);
            this.lblTabanMaasi.TabIndex = 1;
            this.lblTabanMaasi.Text = "Ad:";
            this.lblTabanMaasi.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(48, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Taban Maaşı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCocukSayisi);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblEsYasiyorMu);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblEvlilikDurumu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblCalismaSuresi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblYas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblSoyad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblAd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(32, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 323);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişisel Bilgiler";
            // 
            // lblCocukSayisi
            // 
            this.lblCocukSayisi.AutoSize = true;
            this.lblCocukSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCocukSayisi.Location = new System.Drawing.Point(169, 262);
            this.lblCocukSayisi.Name = "lblCocukSayisi";
            this.lblCocukSayisi.Size = new System.Drawing.Size(24, 15);
            this.lblCocukSayisi.TabIndex = 13;
            this.lblCocukSayisi.Text = "Ad:";
            this.lblCocukSayisi.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(21, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Çocuk Sayısı:";
            // 
            // lblEsYasiyorMu
            // 
            this.lblEsYasiyorMu.AutoSize = true;
            this.lblEsYasiyorMu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEsYasiyorMu.Location = new System.Drawing.Point(441, 192);
            this.lblEsYasiyorMu.Name = "lblEsYasiyorMu";
            this.lblEsYasiyorMu.Size = new System.Drawing.Size(24, 15);
            this.lblEsYasiyorMu.TabIndex = 11;
            this.lblEsYasiyorMu.Text = "Ad:";
            this.lblEsYasiyorMu.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(293, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Eş Yaşıyor mu:";
            // 
            // lblEvlilikDurumu
            // 
            this.lblEvlilikDurumu.AutoSize = true;
            this.lblEvlilikDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvlilikDurumu.Location = new System.Drawing.Point(441, 131);
            this.lblEvlilikDurumu.Name = "lblEvlilikDurumu";
            this.lblEvlilikDurumu.Size = new System.Drawing.Size(24, 15);
            this.lblEvlilikDurumu.TabIndex = 9;
            this.lblEvlilikDurumu.Text = "Ad:";
            this.lblEvlilikDurumu.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(293, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Evlilik Durumu:";
            // 
            // lblCalismaSuresi
            // 
            this.lblCalismaSuresi.AutoSize = true;
            this.lblCalismaSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalismaSuresi.Location = new System.Drawing.Point(441, 68);
            this.lblCalismaSuresi.Name = "lblCalismaSuresi";
            this.lblCalismaSuresi.Size = new System.Drawing.Size(24, 15);
            this.lblCalismaSuresi.TabIndex = 7;
            this.lblCalismaSuresi.Text = "Ad:";
            this.lblCalismaSuresi.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(293, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Çalışma Süresi:";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.Location = new System.Drawing.Point(169, 208);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(24, 15);
            this.lblYas.TabIndex = 5;
            this.lblYas.Text = "Ad:";
            this.lblYas.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Yaş:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(169, 137);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(24, 15);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "Ad:";
            this.lblSoyad.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(169, 68);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 15);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            this.lblAd.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // txbTc
            // 
            this.txbTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbTc.Location = new System.Drawing.Point(88, 223);
            this.txbTc.Name = "txbTc";
            this.txbTc.Size = new System.Drawing.Size(190, 21);
            this.txbTc.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC:";
            // 
            // btnAra
            // 
            this.btnAra.Enabled = false;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(305, 218);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(63, 26);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmCalisanBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1516, 770);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnEkle);
            this.Name = "FrmCalisanBilgi";
            this.Text = "Çalışan Kayıt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCocukSayisi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEsYasiyorMu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblEvlilikDurumu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCalismaSuresi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBrutMaas;
        private System.Windows.Forms.Label label323;
        private System.Windows.Forms.Label lblVergiMatrahı;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFazlaMesaiUcreti;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFazlaMesaiSaati;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblIdariGorevTazminati;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblMakamTazminati;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblTabanMaasi;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblNetMaasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmekliKesintisi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblGelirVergisi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDamgaVergisi;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}

