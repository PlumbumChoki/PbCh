using System.IO;
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

namespace HW_3._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Person person = new Person();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var thread = new Thread(WriteToFile);
            thread.Start();
            MessageBox.Show("Данные успешно записаны!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void WriteToFile()
        {
            using var fileStream = new FileStream(@"C:\Учёба\Системное программирование\HW_3.1\persons.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 0; i < 1_000_000_000; i++)
            {
                byte[] buffer = Encoding.Default.GetBytes(person.ToString());
                fileStream.Write(buffer, 0, buffer.Length);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}