using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _4.Sayfa
{
    public partial class kayitsayfasi : Form
    {
        public kayitsayfasi()
        {
            InitializeComponent();
        }

        private void kayitsayfasi_Load(object sender, EventArgs e)
        {
            pictureBox6.ImageLocation = "add1.png";
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox7.ImageLocation = "logo1.png";
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

        }

       //kayıt sayfasının textboxlarının silik ve kalıcı yazı olmasını sağlayan kodlar.
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "kullanıcı adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "kullanıcı adı";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "e-posta")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "e posta";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "şifre")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.PasswordChar = '*';
            }
        }
        char? none = null;
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "şifre";
                textBox3.ForeColor = Color.Silver;
                textBox3.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "şifre tekrar")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
                textBox4.PasswordChar = '*';
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "şifre tekrar";
                textBox4.ForeColor = Color.Silver;
                textBox4.PasswordChar = Convert.ToChar(none);
            }
        }
     //veritabanı access kodları 
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database5.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void button2_Click(object sender, EventArgs e)
        {

            baglantı.Open();
         OleDbCommand komut = new OleDbCommand("INSERT INTO kayitsayfasiveritabani (kullaniciadi,mail,sifre,telefon) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox5.Text.ToString() + "')", baglantı);
            
            komut.Connection = baglantı;
            komut.ExecuteNonQuery();
            baglantı.Close();
            
            label2.Text = "Kaydınız Başarılı! Giriş yapabilirsiniz.";
            label2.ForeColor =Color.Green;
        }

        private void katalogSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustripten katalog sayfası seçeneği seçilirse o sayfaya geçiş yapar.
            Katalog katalog = new Katalog();
            this.Hide();
            katalog.Show();
        }

        private void restoranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustripten restoran seçeneği seçilirse o sayfaya geçiş yapar.
            Restoran reestoran = new Restoran();
            this.Hide();
            reestoran.Show();
        }

        private void müzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustripten müze seçeneği seçilirse o sayfaya geçiş yapar.
            Muze muze = new Muze();
            this.Hide();
            muze.Show();
        }

        private void konaklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustripten konaklama seçeneği seçilirse o sayfaya geçiş yapar.
            Otel otel = new Otel();
            this.Hide();
            otel.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            türkiye türkiye = new türkiye();
            this.Hide();
            türkiye.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dünya dünya = new dünya();
            dünya.Show();
            this.Hide();
        }

        private void turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tur tur = new Tur();
            this.Hide();
            tur.Show();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa();
            this.Hide();
            ana.Show();
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "telefon numarası")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "telefon numarası";
                textBox5.ForeColor = Color.Silver;
            }
        }

        private void ulaşımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ULASIM ulasim = new ULASIM();
            ulasim.Show();
            this.Hide();
        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            this.Hide();
            odeme.Show();
        }

        private void girişYapınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            girisYapin giris = new girisYapin();
            giris.Show();
            this.Hide();
        }
    }
}
