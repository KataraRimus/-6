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

namespace лб_6 {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            
        }

        public void sum_Click(object sender, RoutedEventArgs e) {
            int zn1 = Convert.ToInt32(z1.Text);
            int zn2 = Convert.ToInt32(z2.Text);
            int zn3 = zn1 + zn2;
            result.Text = zn3.ToString();
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            double zn1 = Convert.ToDouble(z1.Text);
            double zn2 = Convert.ToDouble(z2.Text);
            double zn3 = zn1 / zn2;
            result.Text = zn3.ToString();
        }

        private void mul_Click(object sender, RoutedEventArgs e) {
            double zn1 = Convert.ToDouble(z1.Text);
            double zn2 = Convert.ToDouble(z2.Text);
            double zn3 = zn1 * zn2;
            result.Text = zn3.ToString();
        }

        private void def_Click(object sender, RoutedEventArgs e) {
            
            int zn1 = Convert.ToInt32(z1.Text);
            int zn2 = Convert.ToInt32(z2.Text);
            int zn3 = zn1 - zn2;
            result.Text = zn3.ToString();
        }
    }

}
