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
using System.IO;

namespace Pract7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User CurrentUser = new User();
        public MainWindow()
        {
            InitializeComponent();
            panel1.DataContext = CurrentUser;
        }

        private void Registr(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int count = 0;
            int num1=0, num2=0, num3=0, num4=0, num5=0;
            while (count != 5)
            {
                num1 = random.Next(1, 10);
                do
                {
                    num2 = random.Next(1, 10);
                } while (num1 != num2);
                do
                {
                    num3 = random.Next(1, 10);
                } while (num1 != num3 && num2 != num3);
                do
                {
                    num4 = random.Next(1, 10);
                } while (num1 != num4 && num2 != num4 && num3 != num4);
                do
                {
                    num5 = random.Next(1, 10);
                } while (num1 != num5 && num2 != num5 && num3 != num5 && num4 != num5);

                count++;
            }
            string id=$"{num1}{num2}{num3}{num4}{num5}";
            CurrentUser.Id = id;
            string file = $"D_{id}";
            string info = $"\"Name\": \"{CurrentUser.Name}\",\r\n\"LastName\": \"{CurrentUser.LastName}\",\r\n\"MiddleName\": \"{CurrentUser.MiddleName}\",\r\n\"Specialisation\": \"{CurrentUser.Specialisation}\",\r\n\"Password\": \"{CurrentUser.Password}\"";
            File.WriteAllText(file, info);
        }

        private void Input(object sender, RoutedEventArgs e)
        {

        }
    }
}