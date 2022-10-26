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
    /// Логика взаимодействия для Test4.xaml
    /// </summary>
    public partial class Test4 : Window
    {
        public string login;
        public string password;
        public Test4(string pas, string log)
        {
            InitializeComponent();
            login = log;
            password = pas;
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                  int c = 0;
            if (Ot1.Text == "1972")
            {
                c = c + 1;

            }

            if (Ot2.Text == "//")
            {
                c = c + 1;

            }

            if (Ot3.Text == "string")
            {
                c = c + 1;

            }

            if (Ot4.Text == "int char")
            {
                c = c + 1;

            }

            if (Ot5.Text == "остаток делеия")
            {
                c = c + 1;

            }


            if (c >= 4)
            {
                this.Hide();
                Sertif test = new Sertif(password, login);
                test.Show();
            }
            else
            {
                this.Hide();
                Zanovo test = new Zanovo(password, login);
                test.Show();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Test a = new Test(password, login);
            a.Show();
        }
    }
    }

