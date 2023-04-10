using Mail_Gönderme_Uygulaması.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Gönderme_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        string EkDosya = null;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Gönderici için ek dosya seçebilirsiniz.";
            ofd.ShowDialog();
            textBox4.Text = ofd.FileName;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadsoyad_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Microsoft")
            {
                SendMail sm = new SendMail();
                sm.Microsof(GondericiAdSoyad.Text, textBox6.Text, textBox5.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("Mailiniz Başarıyla gönderilmiştir.");


            }
        }
    }
}
    