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

namespace Тестирование
{
    /// <summary>
    /// Логика взаимодействия для Zanovo.xaml
    /// </summary>
    public partial class Zanovo : Window
    {
        private string password;
        private string login;
        public Zanovo(string pas, string log)
        {
            InitializeComponent();
            login = log;
            password = pas;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Test a = new Test(password, login);
            a.Show();
        }
    }
}
