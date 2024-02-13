using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSimpleGUI
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string txt = TextBox1.Text;

            TextBox1.Text = TextBox2.Text;
            TextBox2.Text = TextBox3.Text;
            TextBox3.Text = TextBox4.Text;
            TextBox4.Text = txt;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string txt = TextBox1.Text;

            TextBox1.Text = TextBox4.Text;
            TextBox4.Text = TextBox3.Text;
            TextBox3.Text = TextBox2.Text;
            TextBox2.Text = txt;
        }
    }
}