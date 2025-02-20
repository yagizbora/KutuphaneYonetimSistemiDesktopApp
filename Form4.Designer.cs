namespace KutuphaneYonetimSistemi
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            textBoxusername = new TextBox();
            label1 = new Label();
            textBoxpassword = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxusername
            // 
            textBoxusername.Location = new Point(57, 43);
            textBoxusername.Name = "textBoxusername";
            textBoxusername.Size = new Size(117, 23);
            textBoxusername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(57, 25);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı adı";
            // 
            // textBoxpassword
            // 
            textBoxpassword.Location = new Point(57, 104);
            textBoxpassword.Name = "textBoxpassword";
            textBoxpassword.Size = new Size(117, 23);
            textBoxpassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 86);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(57, 143);
            button1.Name = "button1";
            button1.Size = new Size(117, 35);
            button1.TabIndex = 4;
            button1.Text = "Kullanıcıyı Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(221, 222);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBoxpassword);
            Controls.Add(label1);
            Controls.Add(textBoxusername);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Kullanıcı Oluştur";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxusername;
        private Label label1;
        private TextBox textBoxpassword;
        private Label label2;
        private Button button1;
    }
}