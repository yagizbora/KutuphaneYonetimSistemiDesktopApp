namespace KutuphaneYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBoxKullaniciAdi = new TextBox();
            textBoxSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(157, 182);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 0;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(157, 69);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(167, 23);
            textBoxKullaniciAdi.TabIndex = 1;
            textBoxKullaniciAdi.KeyDown += textBoxKullaniciAdi_KeyDown;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(157, 133);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(167, 23);
            textBoxSifre.TabIndex = 2;
            textBoxSifre.UseSystemPasswordChar = true;
            textBoxSifre.KeyDown += textBoxSifre_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(13, 65);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(40, 133);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 4;
            label2.Text = "Şifre :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxSifre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxKullaniciAdi);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 239);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            groupBox1.PreviewKeyDown += groupBox1_PreviewKeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(471, 374);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Kütüphane Yönetim Sistemi Giriş Ekranı";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
    }
}
