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

namespace KofteciYusuf.comWPF
{
    /// <summary>
    /// Interaction logic for Tatlı.xaml
    /// </summary>
    public partial class Tatlı : Window
    {
        public Tatlı()
        {
            InitializeComponent();
        }
        private void Anamenü(object sender, RoutedEventArgs e)
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

        private void Hakkimizda(object sender, RoutedEventArgs e)
        {
            Hakkimizdamenü hakkımızda = new Hakkimizdamenü();
            this.Close();
            hakkımızda.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UyeGiris uyegiris = new UyeGiris();
            this.Close();
            uyegiris.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CigUrunler cigürün = new CigUrunler();
            this.Close();
            cigürün.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Kahvaltı kahvaltı = new Kahvaltı();
            this.Close();
            kahvaltı.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Döner döner = new Döner();
            this.Close();
            döner.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Salata salata = new Salata();
            this.Close();
            salata.Show();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Tatlı tatlı = new Tatlı();
            this.Close();
            tatlı.Show();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Şarküteri sarküteri = new Şarküteri();
            this.Close();
            sarküteri.Show();
        }
        private void İcecek(object sender, RoutedEventArgs e)
        {
            Icecekler icecek = new Icecekler();
            this.Close();
            icecek.Show();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Izgaraetlermenü ızgara = new Izgaraetlermenü();
            this.Close();
            ızgara.Show();
        }

        private void UrunDetayClick(object sender, RoutedEventArgs e)
        {
            UrunDetayPage urundetay = new UrunDetayPage();
            this.Close();
            urundetay.Show();
        }

      
    }
}
