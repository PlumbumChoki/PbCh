using System.Diagnostics;
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

namespace HW_2._2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Process? process;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            process = Process.Start("C:\\Учёба\\Системное программирование\\HW_2.2\\HW_2.2\\bin\\Debug\\net8.0-windows\\HW_2.2.exe");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            process?.Kill();
            process = null;
        }
    }
}