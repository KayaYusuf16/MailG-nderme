namespace Mail_Gönderme_Uygulaması
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtgondericialici = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtbaslik = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txticerik = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtek = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtgondericipassword = new System.Windows.Forms.Label();
            this.txtgondericimail = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.Label();
            this.GondericiAdSoyad = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 20);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtgondericialici
            // 
            this.txtgondericialici.AutoSize = true;
            this.txtgondericialici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgondericialici.Location = new System.Drawing.Point(24, 164);
            this.txtgondericialici.Name = "txtgondericialici";
            this.txtgondericialici.Size = new System.Drawing.Size(32, 16);
            this.txtgondericialici.TabIndex = 2;
            this.txtgondericialici.Text = "Alıcı";
            this.txtgondericialici.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 203);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 20);
            this.textBox2.TabIndex = 0;
            // 
            // txtbaslik
            // 
            this.txtbaslik.AutoSize = true;
            this.txtbaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbaslik.Location = new System.Drawing.Point(24, 207);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Size = new System.Drawing.Size(44, 16);
            this.txtbaslik.TabIndex = 2;
            this.txtbaslik.Text = "Başlık";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 246);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(312, 76);
            this.textBox3.TabIndex = 0;
            // 
            // txticerik
            // 
            this.txticerik.AutoSize = true;
            this.txticerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txticerik.Location = new System.Drawing.Point(24, 247);
            this.txticerik.Name = "txticerik";
            this.txticerik.Size = new System.Drawing.Size(39, 16);
            this.txticerik.TabIndex = 2;
            this.txticerik.Text = "İçerik";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtek
            // 
            this.txtek.AutoSize = true;
            this.txtek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtek.Location = new System.Drawing.Point(24, 349);
            this.txtek.Name = "txtek";
            this.txtek.Size = new System.Drawing.Size(23, 16);
            this.txtek.TabIndex = 4;
            this.txtek.Text = "Ek";
            this.txtek.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(207, 345);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 20);
            this.textBox4.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(27, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(398, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Gönder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtgondericipassword
            // 
            this.txtgondericipassword.AutoSize = true;
            this.txtgondericipassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgondericipassword.Location = new System.Drawing.Point(24, 87);
            this.txtgondericipassword.Name = "txtgondericipassword";
            this.txtgondericipassword.Size = new System.Drawing.Size(128, 16);
            this.txtgondericipassword.TabIndex = 9;
            this.txtgondericipassword.Text = "Gönderici Password";
            // 
            // txtgondericimail
            // 
            this.txtgondericimail.AutoSize = true;
            this.txtgondericimail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgondericimail.Location = new System.Drawing.Point(24, 44);
            this.txtgondericimail.Name = "txtgondericimail";
            this.txtgondericimail.Size = new System.Drawing.Size(93, 16);
            this.txtgondericimail.TabIndex = 10;
            this.txtgondericimail.Text = "Gönderici Mail";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 83);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(267, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(158, 43);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(267, 20);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "yusufff_kayaaa@hotmail.com";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.AutoSize = true;
            this.txtadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsoyad.Location = new System.Drawing.Point(24, 9);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(128, 16);
            this.txtadsoyad.TabIndex = 12;
            this.txtadsoyad.Text = "Gönderici Ad Soyad";
            this.txtadsoyad.Click += new System.EventHandler(this.txtadsoyad_Click);
            // 
            // GondericiAdSoyad
            // 
            this.GondericiAdSoyad.Location = new System.Drawing.Point(158, 8);
            this.GondericiAdSoyad.Name = "GondericiAdSoyad";
            this.GondericiAdSoyad.Size = new System.Drawing.Size(267, 20);
            this.GondericiAdSoyad.TabIndex = 11;
            this.GondericiAdSoyad.Text = "Yusuf Kaya";
            this.GondericiAdSoyad.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Microsoft",
            "Google"});
            this.comboBox1.Location = new System.Drawing.Point(158, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sunucu Seçin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.GondericiAdSoyad);
            this.Controls.Add(this.txtgondericipassword);
            this.Controls.Add(this.txtgondericimail);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txticerik);
            this.Controls.Add(this.txtbaslik);
            this.Controls.Add(this.txtgondericialici);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label txtgondericialici;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtbaslik;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txticerik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtek;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtgondericipassword;
        private System.Windows.Forms.Label txtgondericimail;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label txtadsoyad;
        private System.Windows.Forms.TextBox GondericiAdSoyad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

