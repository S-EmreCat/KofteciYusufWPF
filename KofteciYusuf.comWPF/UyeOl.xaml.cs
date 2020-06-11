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
using System.Data.SqlClient;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KofteciYusuf.comWPF
{
   
    public partial class UyeOl : Window
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TMO20IJ\\POTSQL;Initial Catalog=Koftedeneme;Integrated Security=True");

        private void Anasayfa(object sender, RoutedEventArgs e)
        {
            MainWindow anamenü = new MainWindow();
            this.Close();
            anamenü.Show();
        }

        private void Btn_urunlerimiz_Click(object sender, RoutedEventArgs e)
        {
      
            Izgaraetlermenü ızgaraetler = new Izgaraetlermenü();
            this.Close();
            ızgaraetler.Show();
        }
        // üye giriş sayfacı click
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UyeGiris uyegiris = new UyeGiris();
            this.Close();
            uyegiris.Show();
        }

        private void Hakkimizda(object sender, RoutedEventArgs e)
        {

            Hakkimizdamenü hakkımızda = new Hakkimizdamenü();
            this.Close();
            hakkımızda.Show();
        }

        private void Uyetamam(object sender, RoutedEventArgs e)
        {
            if (CheckOkudum.IsChecked==true)
            {
                
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into üyeler (eposta,sifre) values (@p1,@p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", Txtbkayıteposta.Text);
                komut.Parameters.AddWithValue("@p2", passkayıtsifre.Password.ToString());
                komut.ExecuteNonQuery();
                MessageBox.Show("üyelik tamamlandı");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("'Okudum, Kabul Ediyorum.' Seçeneğini işaretleyiniz.");
            }
        }
    }

    

}
