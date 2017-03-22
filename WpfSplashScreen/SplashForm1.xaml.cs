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

namespace WpfSplashScreen
{
    /// <summary>
    /// Interaction logic for xSplashForm1.xaml
    /// </summary>
    public partial class xSplashForm1 : Window
    {
        public xSplashForm1()
        {
            InitializeComponent();
        }

        private void xCloseButtonForm1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void xPlayButtomForm1_Click(object sender, RoutedEventArgs e)
        {
            FormPlayer play = new FormPlayer();
            play.Show(); 
        }
    }
}
