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
    /// Interaction logic for Hakkimizdamenü.xaml
    /// </summary>
    public partial class Hakkimizdamenü : Window
    {
        public Hakkimizdamenü()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow anamenü = new MainWindow();
            this.Close();
            anamenü.Show();
        }

        private void Btn_urunlerimiz_Click(object sender, RoutedEventArgs e)
        {
            Izgaraetlermenü izgara = new Izgaraetlermenü();
            this.Close();
            izgara.Show();
        }

        private void Hakkimizda(object sender, RoutedEventArgs e)
        {
            Hakkimizdamenü hakkımızda = new Hakkimizdamenü();
            this.Close();
            hakkımızda.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UyeGiris uyegiris = new UyeGiris();
            this.Close();
            uyegiris.Show();
        }
    }
}