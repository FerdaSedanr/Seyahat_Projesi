using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }

        adminSehir gir = new adminSehir();
        //adminSehir classına gir ile ulaşıp textleri alıyoruz nesne yapmış olduk.

        private void admingiris_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            this.MaximizeBox = false;
            BackColor = Color.Silver;
            menuStrip1.BackColor = Color.Silver;

            //dosyadan icon pnglerini pictureboxlara atadık.

            pictureBox1.ImageLocation = "adminicongirl.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.ImageLocation = "logo1.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.ImageLocation = "adminicon.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.ImageLocation = "sifregir.png";
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            //adminSehir classından textleri aldık labellara yerleştirdik.

            label1.Text = gir.l1;
            label2.Text = gir.l2;
            label3.Text = gir.l3;
            button1.Text = gir.l4;
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //giriş nesnesiyle anasayfaya geri döndük.
            anasayfa giris = new anasayfa();
            giris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //admingiris formunda giriş aptıktan sonra 
            admingiris2 gecis = new admingiris2();

            if ((textBox1.Text == "admin") && (textBox2.Text == "123456"))
            {
                //kullanıcı adı ve sifre doğrulandığı sürece andminGiris2'ye geçilmesi şartı gerektiği için if else kullandık.
                gecis.Show();
                this.Hide();

            }

            else
            {
                //yanlis kullanici adi veya sifre koşulunda formdaki değişiklikler ve hata mesajı:
                textBox2.Clear();
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBox1.ForeColor = Color.White;
                textBox2.ForeColor = Color.White;
                MessageBox.Show("Kullanıcı Adı veya Parola hatalı!");
            }
        }
    }
}
