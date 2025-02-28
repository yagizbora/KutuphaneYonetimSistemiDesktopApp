namespace KutuphaneYonetimSistemi
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            textBoxpassword = new TextBox();
            button1 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // textBoxpassword
            // 
            textBoxpassword.Location = new Point(79, 30);
            textBoxpassword.Name = "textBoxpassword";
            textBoxpassword.Size = new Size(129, 23);
            textBoxpassword.TabIndex = 0;
            textBoxpassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(79, 59);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Doğrula";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Parola";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(214, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Parolayı göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(324, 104);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxpassword);
            Controls.Add(checkBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Kontrol";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxpassword;
        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
    }
}