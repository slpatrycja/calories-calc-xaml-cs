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
using System.Windows.Navigation;
using System.Windows.Shapes;




namespace kalkulatorKcal
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Przelicznik przelicznik = new Przelicznik();
            przelicznik.Ilosc = Int32.Parse(waga.Text);
            przelicznik.UstawKalorycznosc(Int32.Parse(kalorie.Text));
            przelicznik.UstawRodzaj(lista.SelectedItem.ToString());
            poleWyniku.Text = "Zjadłeś/aś" + przelicznik.ZwrocRodzaj() + "o wadze" + przelicznik.Ilosc + "co daje" + przelicznik.Oblicz() + "kalorii.";
        }
    }
}
