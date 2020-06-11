using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace KofteciYusuf.comWPF
{
    /// <summary>
    /// Interaction logic for UyeGiris.xaml
    /// </summary>
    public partial class UyeGiris : Window
    {
        public UyeGiris()
        {
            InitializeComponent();
        }
        
        private void Anasayfa(object sender, RoutedEventArgs e)
        {
            MainWindow anamenü = new MainWindow();
            this.Close();
            anamenü.Show();
        }

        private void IzgaraEtler(object sender, RoutedEventArgs e)
        {
            Izgaraetlermenü ızgaraetler = new Izgaraetlermenü();
            this.Close();
            ızgaraetler.Show();
        }

        private void Sirket_Profil(object sender, RoutedEventArgs e)
        {
            Hakkimizdamenü hakkımız = new Hakkimizdamenü();
            this.Close();
            hakkımız.Show();
        }

        private void Hakkimizda(object sender, RoutedEventArgs e)
        {
            Hakkimizdamenü hakkımızda = new Hakkimizdamenü();
            this.Close();
            hakkımızda.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UyeOl üyeol = new UyeOl();
            this.Close();
            üyeol.Show();
        }

        private void Btn_urunlerimiz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UyeGiris uyegiris = new UyeGiris();
            this.Close();
            uyegiris.Show();
        }

        // giriş yaparken kullanılan fonk+buton click



        public string geleneposta1;
        public string gelensifre1;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TMO20IJ\\POTSQL;Initial Catalog=Koftedeneme;Integrated Security=True");

        private void GirisYap(object sender, RoutedEventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komutgiris = new SqlCommand("select * from üyeler where eposta=@p1 and sifre=@p2", baglanti);
            komutgiris.Parameters.AddWithValue("@p1", TxtbEposta.Text);
            komutgiris.Parameters.AddWithValue("@p2", TxtbSifre.Password.ToString());
            SqlDataReader dr = komutgiris.ExecuteReader();
            if (dr.Read())
            {
                MainWindow anasayfa = new MainWindow();
                MessageBox.Show("Giriş Yapılıyor.");
                this.Close();
                anasayfa.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
            }
            baglanti.Close();
        }

        
    }
}
