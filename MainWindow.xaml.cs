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

namespace _184648IPO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            Double soup;
            Double people;
            Double need;
            Double price;

            Double.TryParse(txtBInput1.Text, out soup);
            Double.TryParse(txtBInput2.Text, out people);

            need = soup * people;

            price = need * 4.99;

            lblOutput.Content = "You will need " + need.ToString("#.00") + " bowls of Corn Soup";
            lblPrice.Content = "This will cost $" + price.ToString("#.00") + " in total";
        }
    }
}
