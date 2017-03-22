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

namespace WpfSplashScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       xSplashForm1 m = new xSplashForm1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void move(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void xCloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        private void xMinButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((xUserNameTextBox.Text == "Teacher") & (xPasswordTextBox.Password == "Password"))
            {
                this.Close();
                m.Show();
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password");
            }
        }

        private void xUserNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
