namespace KutuphaneYonetimSistemi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            buttonClearFilter = new Button();
            buttonKitapSilme = new Button();
            buttonara = new Button();
            kitapid = new Label();
            buttonKitapBilgiGuncelle = new Button();
            buttonKitapEkle = new Button();
            textBoxKitapTurKodu = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarSoyadi = new TextBox();
            textBoxYazarAdi = new TextBox();
            textBoxKitapAdi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonKitabiOduncVer = new Button();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            textBoxOduncAlan = new TextBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            label12 = new Label();
            labelgecikmebedeli = new Label();
            label10 = new Label();
            dataGridViewKitaplar = new DataGridView();
            label7 = new Label();
            groupBox4 = new GroupBox();
            buttonDeleteBookType = new Button();
            label11 = new Label();
            button3 = new Button();
            textBoxBookType = new TextBox();
            dataGridView1 = new DataGridView();
            printDialog1 = new PrintDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonClearFilter);
            groupBox1.Controls.Add(buttonKitapSilme);
            groupBox1.Controls.Add(buttonara);
            groupBox1.Controls.Add(kitapid);
            groupBox1.Controls.Add(buttonKitapBilgiGuncelle);
            groupBox1.Controls.Add(buttonKitapEkle);
            groupBox1.Controls.Add(textBoxKitapTurKodu);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxYazarSoyadi);
            groupBox1.Controls.Add(textBoxYazarAdi);
            groupBox1.Controls.Add(textBoxKitapAdi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kayıt ve güncelleme";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonClearFilter
            // 
            buttonClearFilter.Location = new Point(324, 234);
            buttonClearFilter.Name = "buttonClearFilter";
            buttonClearFilter.Size = new Size(84, 39);
            buttonClearFilter.TabIndex = 16;
            buttonClearFilter.Text = "Temizle";
            buttonClearFilter.UseVisualStyleBackColor = true;
            buttonClearFilter.Click += buttonClearFilter_Click;
            // 
            // buttonKitapSilme
            // 
            buttonKitapSilme.Location = new Point(414, 234);
            buttonKitapSilme.Name = "buttonKitapSilme";
            buttonKitapSilme.Size = new Size(84, 39);
            buttonKitapSilme.TabIndex = 15;
            buttonKitapSilme.Text = "Sil";
            buttonKitapSilme.UseVisualStyleBackColor = true;
            buttonKitapSilme.Click += buttonKitapSilme_Click;
            // 
            // buttonara
            // 
            buttonara.Location = new Point(218, 234);
            buttonara.Name = "buttonara";
            buttonara.Size = new Size(100, 39);
            buttonara.TabIndex = 14;
            buttonara.Text = "Ara";
            buttonara.UseVisualStyleBackColor = true;
            buttonara.Click += buttonara_Click;
            // 
            // kitapid
            // 
            kitapid.AutoSize = true;
            kitapid.Location = new Point(98, 28);
            kitapid.Name = "kitapid";
            kitapid.Size = new Size(12, 15);
            kitapid.TabIndex = 13;
            kitapid.Text = "-";
            // 
            // buttonKitapBilgiGuncelle
            // 
            buttonKitapBilgiGuncelle.Location = new Point(6, 234);
            buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            buttonKitapBilgiGuncelle.Size = new Size(100, 39);
            buttonKitapBilgiGuncelle.TabIndex = 12;
            buttonKitapBilgiGuncelle.Text = "Kitap bilgi güncelle";
            buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            buttonKitapBilgiGuncelle.Click += buttonKitapBilgiGuncelle_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Location = new Point(112, 234);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(100, 39);
            buttonKitapEkle.TabIndex = 11;
            buttonKitapEkle.Text = "Yeni kitap ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // textBoxKitapTurKodu
            // 
            textBoxKitapTurKodu.Location = new Point(98, 199);
            textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            textBoxKitapTurKodu.Size = new Size(100, 23);
            textBoxKitapTurKodu.TabIndex = 10;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(98, 162);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(100, 23);
            textBoxISBN.TabIndex = 9;
            // 
            // textBoxYazarSoyadi
            // 
            textBoxYazarSoyadi.Location = new Point(98, 127);
            textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            textBoxYazarSoyadi.Size = new Size(100, 23);
            textBoxYazarSoyadi.TabIndex = 8;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Location = new Point(98, 96);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(100, 23);
            textBoxYazarAdi.TabIndex = 7;
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Location = new Point(98, 61);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(100, 23);
            textBoxKitapAdi.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 199);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 5;
            label6.Text = "Kitap Tür Kodu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 162);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 127);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Yazar Soyadı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 96);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Yazar Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 28);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonKitabiOduncVer);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Location = new Point(958, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(253, 279);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitabiOduncVer
            // 
            buttonKitabiOduncVer.Location = new Point(107, 138);
            buttonKitabiOduncVer.Name = "buttonKitabiOduncVer";
            buttonKitabiOduncVer.Size = new Size(100, 39);
            buttonKitabiOduncVer.TabIndex = 21;
            buttonKitabiOduncVer.Text = "Kitabı Ödünç Ver";
            buttonKitabiOduncVer.UseVisualStyleBackColor = true;
            buttonKitabiOduncVer.Click += buttonKitabiOduncVer_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 23);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.Value = new DateTime(2025, 2, 15, 11, 4, 5, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 104);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 15;
            label9.Text = "Tarih";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 62);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 13;
            label8.Text = "Ödünç Alan";
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Location = new Point(107, 54);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(137, 23);
            textBoxOduncAlan.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(labelgecikmebedeli);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(1217, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(211, 277);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap Iade";
            // 
            // button2
            // 
            button2.Location = new Point(39, 162);
            button2.Name = "button2";
            button2.Size = new Size(100, 39);
            button2.TabIndex = 20;
            button2.Text = "Kitabı iade et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 104);
            button1.Name = "button1";
            button1.Size = new Size(100, 39);
            button1.TabIndex = 13;
            button1.Text = "Gecikme Bedeli hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(160, 54);
            label12.Name = "label12";
            label12.Size = new Size(20, 15);
            label12.TabIndex = 19;
            label12.Text = "TL";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelgecikmebedeli
            // 
            labelgecikmebedeli.AutoSize = true;
            labelgecikmebedeli.Location = new Point(126, 54);
            labelgecikmebedeli.Name = "labelgecikmebedeli";
            labelgecikmebedeli.Size = new Size(13, 15);
            labelgecikmebedeli.TabIndex = 18;
            labelgecikmebedeli.Text = "0";
            labelgecikmebedeli.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 54);
            label10.Name = "label10";
            label10.Size = new Size(91, 15);
            label10.TabIndex = 17;
            label10.Text = "Gecikme Bedeli:";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Location = new Point(12, 332);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.Size = new Size(1416, 257);
            dataGridViewKitaplar.TabIndex = 3;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 314);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 4;
            label7.Text = "Kitap Listesi";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonDeleteBookType);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(textBoxBookType);
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(605, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(337, 283);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Türleri";
            // 
            // buttonDeleteBookType
            // 
            buttonDeleteBookType.Location = new Point(6, 239);
            buttonDeleteBookType.Name = "buttonDeleteBookType";
            buttonDeleteBookType.Size = new Size(93, 28);
            buttonDeleteBookType.TabIndex = 4;
            buttonDeleteBookType.Text = "Kitap Türü Sil";
            buttonDeleteBookType.UseVisualStyleBackColor = true;
            buttonDeleteBookType.Click += buttonDeleteBookType_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 28);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 3;
            label11.Text = "Kitap Türü";
            // 
            // button3
            // 
            button3.Location = new Point(212, 44);
            button3.Name = "button3";
            button3.Size = new Size(93, 41);
            button3.TabIndex = 2;
            button3.Text = "Kitap Türü Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBoxBookType
            // 
            textBoxBookType.Location = new Point(6, 54);
            textBoxBookType.Name = "textBoxBookType";
            textBoxBookType.Size = new Size(175, 23);
            textBoxBookType.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(325, 135);
            dataGridView1.TabIndex = 0;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1434, 601);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(label7);
            Controls.Add(dataGridViewKitaplar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            Text = "Kütüphane Yönetim Paneli";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyadi;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private Button buttonKitapBilgiGuncelle;
        private Button buttonKitapEkle;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private Label label8;
        private TextBox textBoxOduncAlan;
        private DataGridView dataGridViewKitaplar;
        private Label label7;
        private Label labelgecikmebedeli;
        private Label label10;
        private Button button2;
        private Button button1;
        private Label label12;
        private Label kitapid;
        private Button buttonKitabiOduncVer;
        private Button buttonara;
        private Button buttonKitapSilme;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Label label11;
        private Button button3;
        private TextBox textBoxBookType;
        private Button buttonClearFilter;
        private Button buttonDeleteBookType;
        private PrintDialog printDialog1;
    }
}