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
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Window
    {

        string[] test;
        public string login;
        public string password;
        public Test1(string pas, string log)
        {
            InitializeComponent();
            Randim randim = new Randim();
            test = randim.Rsnd();
            label1.Content = test[0];
            label2.Content = test[2];
            label3.Content = test[4];


            login = log;
            password = pas;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int c = 0;
            if (Ot1.Text == test[1])
            {
                c=c+1;

            }

            if (Ot2.Text == test[3])
            {
                c = c + 1;

            }

            if (Ot3.Text == test[5])
            {
                c = c + 1;

            }

            if (Ot4.Text == "Ссылочным" || Ot4.Text == "ccskjxysv")
            {
                c = c + 1;

            }

            if (Ot5.Text == "while" || Ot5.Text == "вайл")
            {
                c = c + 1;

            }
            
        
            if (c >= 0)
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
