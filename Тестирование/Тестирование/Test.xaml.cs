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
using static System.Net.Mime.MediaTypeNames;

namespace Тестирование
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public string login;
        public string password;
        public Test(string pas, string log)
        {
            InitializeComponent();
            login = log;
            password = pas;

        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Test1 test = new Test1(password, login);
            test.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Test2 test = new Test2(password, login);
            test.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Test3 test = new Test3(password, login);
            test.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Test4 test = new Test4(password, login);
            test.Show();
        }
    }
}
