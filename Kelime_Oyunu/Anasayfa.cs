using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Oyunu
{   //171307065_ARDA_ERTAN
    public partial class Anasayfa : Form
    {

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=kelime_oyunu;Uid=root;Pwd='';");
        public static string kullanici_adi;
        ArrayList maxskor = new ArrayList();
        public Anasayfa()
        {
            InitializeComponent();
        }
        void enyuksekskor()
        {
          
            MySqlCommand max = new MySqlCommand("SELECT * FROM kullanici ORDER BY Skor DESC", mysqlbaglan);
            try
            {
                mysqlbaglan.Open();
                MySqlDataReader reader = max.ExecuteReader();

                while (reader.Read())
                {
                    

                    listBox1.Items.Add(reader["Kullanici_Adi"].ToString() +"   "+ reader["Skor"].ToString()+"   "+ reader["Sure"].ToString()+"   "+ reader["tarih"].ToString());

                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Çekilemedi");
            }
            finally
            {
                mysqlbaglan.Close();
            }

        }
    
        void soruekle()
        {
            try
            {

                // bağlantıyı açalım
                mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into sorular (Soru,Cevap,harf_sayisi) values ('" + textBox2.Text + "','" + textBox3.Text+ "','" +  textBox3.Text.Length + "')", mysqlbaglan);
                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                if (sonuc != null)
                    MessageBox.Show("Sorunuz sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sorunuz sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // bağlantıyı kapatalım
                mysqlbaglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        void kullaniciekle()
        {
            try
            {
                // bağlantıyı açalım
                mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into kullanici (Kullanici_Adi) values ('" + textBox1.Text + "')", mysqlbaglan);
                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                if (sonuc != null)
                    MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // bağlantıyı kapatalım
                mysqlbaglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kullanici Adi- -Skor- -Sure- -Tarih");
            enyuksekskor();
            /*listBox1.Items.Clear();
            maxskor.Sort();
            for (int i = 0; i < maxskor.Count; i++)
            {
                listBox1.Items.Add(maxskor[i]);
            }*/

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            textBox3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bir önceki formdan veri cekmek amacıyla tanımladık
            Oyun_Ekrani form2 = new Oyun_Ekrani();
            kullanici_adi = textBox1.Text;
            this.Hide();
            kullaniciekle();
            Oyun_Ekrani oyunekrani = new Oyun_Ekrani();
            oyunekrani.Show();


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                button2.Enabled = true;
            }
            else
                button2.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                button3.Enabled = true;
            }
            else
                button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            soruekle();
        }
    } 
}

