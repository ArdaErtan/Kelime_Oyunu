using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Kelime_Oyunu
{
    //171307065_ARDA_ERTAN
    public partial class Oyun_Ekrani : Form
    {

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=kelime_oyunu;Uid=root;Pwd='';");
        ArrayList sorular = new ArrayList();
        ArrayList cevaplar = new ArrayList();
        ArrayList harfcevaplar = new ArrayList();
        Random rasgele = new Random();
        /*//anasayfada kullanıcıdan aldıgımız isim 
        public string kullanici_adi;*/

        public int rndsoru=0;
        //sayaclarımızın tanımlanması
        int soru_sayac = 1;
        int kontrol_sayac = 2;
        int harf_sayisi = 4;
        int sayac = 240;
        int tahmin_sayac = 20;
        int t_harfsayisi=999;
        int t_rndsoru = 0;
        int puan = 0;


        //cevabın harf sayisina göre soru çeker
        void kullanici_sonucu()
        {
            try
            {
                string sonucsql = "update kullanici set Skor = '" + puan + "',Sure = '" + sayac.ToString() + "', tarih = '" + DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + "' where Kullanici_Adi = '" + Anasayfa.kullanici_adi  + "'";
                mysqlbaglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand(sonucsql, mysqlbaglan);
                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                if (sonuc != null)
                    MessageBox.Show("Sisteme kullanıcı sonucu başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sisteme kullanıcı sonucu eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // bağlantıyı kapatalım
                mysqlbaglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void harfsayisinasoru(int harfsayisi)
        {

            
            sorular.Clear();
            cevaplar.Clear();
           
            string sorucek = "SELECT * FROM sorular where harf_sayisi ="+harfsayisi;
            MySqlCommand command = new MySqlCommand(sorucek, mysqlbaglan);
            try
            {
                mysqlbaglan.Open();
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    sorular.Add(reader["Soru"]);
                    cevaplar.Add(reader["Cevap"]);


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
            //harf sayısına göre 
            
            

            t_harfsayisi = harfsayisi;

        }
        void soruyazdir(int harfsayisi)
        {
            while(t_rndsoru == rndsoru )
            {
                rndsoru = rasgele.Next(cevaplar.Count);
            }
            
            string cevap = cevaplar[rndsoru].ToString();
            textBox2.Text = sorular[rndsoru].ToString();
            t_rndsoru = rndsoru;
            
            

        }
        void harfiste(int rndsoru ,char [] cevapdizi ,string cevap)
        {
            int rasgeleharf = rasgele.Next(cevapdizi.Length);
            

            if (harfcevaplar.Contains(cevapdizi[rasgeleharf]))
            {
                harfiste(rndsoru,cevapdizi,cevap);
            }
            else {
                switch (rasgeleharf)
                {
                    case 0:
                        harf1.Text = cevapdizi[rasgeleharf].ToString();
                        puan = puan - 100;
                        label5.Text = "Skor = " + puan;
                        break;
                    case 1:
                        harf2.Text = cevapdizi[rasgeleharf].ToString();
                        puan = puan - 100;
                        label5.Text = "Skor = " + puan;
                        break;
                    case 2:
                        harf3.Text = cevapdizi[rasgeleharf].ToString();
                        puan = puan - 100;
                        label5.Text = "Skor = " + puan;
                        break;
                    case 3:
                        harf4.Text = cevapdizi[rasgeleharf].ToString();
                        puan = puan - 100;
                        label5.Text = "Skor = " + puan;
                        break;
                    case 4:
                        harf5.Text = cevapdizi[rasgeleharf].ToString();
                        puan = puan - 100;
                        break;
                    case 5:
                        harf6.Text = cevapdizi[rasgeleharf].ToString();
                        puan = puan - 100;
                        break;
                    case 6:
                        harf7.Text = cevapdizi[rasgeleharf].ToString();
                        puan = puan - 100;
                        break;
                    case 7:
                        harf8.Text = cevapdizi[rasgeleharf].ToString();
                        puan = puan - 100;
                        break;
                    case 8:
                        harf9.Text = cevapdizi[rasgeleharf].ToString();
                        puan = puan - 100;
                        break;
                    case 9:
                        harf10.Text = cevapdizi[rasgeleharf].ToString();
                        puan = puan - 100;
                        break;
                    default:
                        break;
                }
            }
            harfcevaplar.Add(cevapdizi[rasgeleharf]);


        }
      

       
       
        public Oyun_Ekrani()
        {
            InitializeComponent();
        }
        
        //oyun basladıgı takdirde sayac calısır
        private void Oyun_Ekrani_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Anasayfa.kullanici_adi); 
            harfsayisinasoru(harf_sayisi);
            soruyazdir(harf_sayisi);
            /*sqlbaglan();*/
            timer1.Start();
            harf5.Visible = false;
            harf6.Visible = false;
            harf7.Visible = false;
            harf8.Visible = false;
            harf9.Visible = false;
            harf10.Visible = false;
            

        }
        //ana sayacımızın tetiklenme durumu
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sayac--;
            if (sayac == 0)
            {
                timer1.Stop();
                MessageBox.Show("Oyun Bitti !!!"+"Skorunuz = "+puan );
                kullanici_sonucu();
                
            }
            label1.Text = sayac.ToString();
            progressBar1.Value = sayac;
        }

        // tahmin sayacanın tetiklenmesini kontrol ediyor 
        // sayac sıfırlandıgı takdirde anasayacımız tekrar çalışmaya devam ediyor

        private void timer2_Tick(object sender, EventArgs e)
        {
            tahmin_sayac--;
            if (tahmin_sayac == 0)
            {
                cevapkontrol();
                label2.Text = tahmin_sayac.ToString();
                timer2.Stop();
                sorugetir();
                timer1.Start();
                button3.Enabled = false;
                tahmin_sayac = 20;
                label2.Text = tahmin_sayac.ToString();
                cevaptemizle();
                
                         
            }
            else 
            { 
            label2.Text = tahmin_sayac.ToString();
            }
           

        }

        //tahminde bulun butonu
        //tahminde bulundugu süre içerinde normal sürede azalma durdurulacak
        private void button1_Click(object sender, EventArgs e)
        {
            tahmin_sayac = 20;
            button3.Enabled = true;
            timer2.Start();
            timer1.Stop();

        }
        void cevaptemizle()
        {
            harf1.Text = "_";
            harf2.Text = "_";
            harf3.Text = "_";
            harf4.Text = "_";
            harf5.Text = "_";
            harf6.Text = "_";
            harf7.Text = "_";
            harf8.Text = "_";
            harf9.Text = "_";
            harf10.Text = "_";
            textBox1.Text = " ";
      

        }
        void sorugetir()
        {
            cevaptemizle();
            switch (harf_sayisi)
            {
                case 4:

                    break;
                case 5:
                    harf5.Visible = true;
                    break;
                case 6:
                    harf6.Visible = true;
                    break;
                case 7:
                    harf7.Visible = true;
                    break;
                case 8:
                    harf8.Visible = true;
                    break;
                case 9:
                    harf9.Visible = true;
                    break;
                case 10:
                    harf10.Visible = true;
                    break;
                default:
                    break;
            }

            if (soru_sayac >= 0 && soru_sayac <= 14)
            {
                //bir harf sayacını 2 defa yazdırmak için
                if (kontrol_sayac == 1)
                {
                    kontrol_sayac++;
                    harfsayisinasoru(harf_sayisi);
                    soruyazdir(harf_sayisi);
                    if (tahmin_sayac != 0 || tahmin_sayac != 20)
                    {
                        timer2.Stop();
                        tahmin_sayac = 20;
                        label2.Text = tahmin_sayac.ToString();
                    }

                }
                else
                {
                    harfsayisinasoru(harf_sayisi);
                    soruyazdir(harf_sayisi);
                    harf_sayisi++;
                    kontrol_sayac = 1;
                    if (tahmin_sayac != 0 || tahmin_sayac != 20)
                    {
                        timer2.Stop();
                        tahmin_sayac = 20;
                        label2.Text = tahmin_sayac.ToString();
                    }

                }
                soru_sayac++;                
                harfcevaplar.Clear();
            }
        }
        void cevapkontrol()
        {
            string cevap = cevaplar[rndsoru].ToString();
            if (textBox1.Text.ToLower() == cevap.ToLower())
            {
                if (kontrol_sayac == 2)
                { puan = puan + (harf_sayisi * 100); }
                else { puan = puan + ((harf_sayisi * 100) - 100); }

            }
            else
            {
                if (kontrol_sayac == 2)
                { puan = puan - (harf_sayisi * 100); }
                else { puan = puan - ((harf_sayisi * 100) + 100); }
            }

            label5.Text = "Skor = " + puan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            cevapkontrol();
            timer1.Start();
            button3.Enabled = false;
            sorugetir();
            if (soru_sayac == 14)
            {
                timer1.Stop();
                MessageBox.Show("Oyun Bitti"+"Skorunuz = "+puan);
                kullanici_sonucu();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cevap = cevaplar[rndsoru].ToString();
            char[] cevapdizi = cevap.ToCharArray();
            harfiste(rndsoru,cevapdizi,cevap);
        }
    }
}
