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
    /// Логика взаимодействия для Test2.xaml
    /// </summary>
    public partial class Test2 : Window
    {
        public string login;
        public string password;
        public Test2(string pas, string log)
        {
            InitializeComponent();
            login = log;
            password = pas;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
                int c = 0;
            if (Ot1.Text == "Объекта" || Ot1.Text == "объекта")
            {
                c = c + 1;

            }

            if (Ot2.Text == "30")
            {
                c = c + 1;

            }

            if (Ot3.Text == "print" || Ot3.Text == "принт")
            {
                c = c + 1;

            }

            if (Ot4.Text == "Возведение в степень" || Ot4.Text == "возведение в степень")
            {
                c = c + 1;

            }

            if (Ot5.Text == "input")
            {
                c = c + 1;

            }


            if (c >= 4)
            {
                this.Hide();
                Sertif test = new Sertif(password,login);
                test.Show();
            }
            else
            {
                this.Hide();
                Zanovo test = new Zanovo(password,login);
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

