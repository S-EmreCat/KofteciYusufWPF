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
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Net;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KofteciYusuf.comWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var url = "https://localhost:44354/api/products";
            //var json = new WebClient().DownloadString(url);
            //object stuff = JsonConvert.DeserializeObject(json);
            //TextBlock[] texts = { tex1 };

            //for (int i = 0; i < Name.Length; i++)
            //{
            //    var title = stuff[i].Name.ToString();
            //    titles[i].Content = hebele;
            //}         
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

        

        private void Hakkimizda(object sender, RoutedEventArgs e)
        {
            Hakkimizdamenü hakkımızda = new Hakkimizdamenü();
            this.Close();
            hakkımızda.Show();
        }

        private void UyeGiris(object sender, RoutedEventArgs e)
        {
            UyeGiris uyegiris = new UyeGiris();
            this.Close();
            uyegiris.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UyeGiris uyegiris = new UyeGiris();
            this.Close();
            uyegiris.Show();
        }

        private void UrunDetayClick(object sender, RoutedEventArgs e)
        {
            UrunDetayPage urundetay = new UrunDetayPage();
            this.Close();
            urundetay.Show();
        }
    }
}
