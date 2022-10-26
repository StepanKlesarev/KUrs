using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
    /// Логика взаимодействия для Autr.xaml
    /// </summary>
   /* public partial class Autr : Window
    {
        string login;
        string password;
        /*  public Autr()
          {
              InitializeComponent();
              login = L.Text;
              password = P.Text;
          }



          private void Button_Click_1(object sender, RoutedEventArgs e)
          {
              if (L.Text == "student" && P.Text == "student")
              {
                  Test qwe = new Test();
                  this.Hide();
                  qwe.Left = this.Left;
                  qwe.Top = this.Top;
                  qwe.Show();
              }
              else if (L.Text != "student" && P.Text != "student")
              {
                  MessageBox.Show("Не правильно введены поля");
              } 
              else if (L.Text != "student")
              {
              MessageBox.Show("Не правильно введен логин");
              }
              else if (P.Text != "student")
              {
                  MessageBox.Show("Не правильно введен пароль");
              }

          }
      }
  }*/
        public partial class Autr : Window

        {

            public int vov;

            public Autr()

            {

                InitializeComponent();

            }

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                Random random = new Random();
                vov = random.Next();
                string login = L.Text;
                string pasword = P.Password;
                try
                {
                    // отправитель - устанавливаем адрес и отображаемое в письме имя
                    MailAddress from = new MailAddress(login, "Сервис почты праграмистов");
                    // кому отправляем
                    MailAddress to = new MailAddress(login);
                    // создаем объект сообщения
                    MailMessage m = new MailMessage(from, to);
                    // тема письма
                    m.Subject = "Вход в вашу почту";
                    // текст письма
                    m.Body = $"<h2>ВНИМАНИЕ</h2>";
                    m.Body += "В вашу почту кто-то вошёл, убедитесь, что всё хорошо";
                    // письмо представляет код html
                    m.IsBodyHtml = true;
                    // адрес smtp-сервера и порт, с которого будем отправлять письмо
                    string str = "";
                    if (login.Contains("@mpt.ru")) str = "smtp.mpt.ru";
                    else if (login.Contains("@mail.ru")) str = "smtp.mail.ru";
                    SmtpClient smtp = new SmtpClient(str, 587);
                    // логин и пароль
                    smtp.Credentials = new NetworkCredential(login, pasword);
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                    //открытие ввода кода

                    this.Hide();
                    Test a = new Test(pasword, login);
                    a.Show();
                }
                catch
                {
                    MessageBox.Show("Вы ввели логин или пароль не правильно!");
                }

            }

      
    }
    }