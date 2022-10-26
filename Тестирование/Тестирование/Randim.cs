using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace Тестирование
{
    public class Randim
    {
        // public string[,] Tests { get; set; }
        public string[] Rsnd()
        {
            string path = "Test1.txt";




            //string[,] Tests = { {"Что будет выведено на консоль? Console.WriteLine(Int16.MaxValue);","Можно ли сделать перегрузку операторов true и false?","Как обозначается цикл с предусловием?","Тип string является значимым или ссылочным типом?","Верно ли, что тип string хранит набор символов Unicode?" },
            //                {"32767","Да","while","ссылочным","Да"} };



            using (StreamReader reader = new StreamReader(path))
            {
                string line = "t";
                int counter = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    counter++;
                }
                counter /= 2;
                // string[][] Tests = new string[1][counter];
                //string[0][column] Tests;
                string[,] Tests = new string[counter,1 ];

                for (int i = 0; i < counter; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Tests[i, j] = reader.ReadLine();
                        //Console.Write(mas[i, j] + " ");
                    }

                }



                Random random = new Random();
                int num1 = random.Next(4);
                int num2 = random.Next(5);
                int num3 = random.Next(5);
                int num4 = random.Next(5);
                int num5 = random.Next(5);


                // MessageBox.Show(Tests[0, mas]);

                string[] Result = { Tests[0, num1], Tests[1, num1], Tests[0, num2], Tests[1, num2], Tests[0, num3], Tests[1, num3], Tests[0, num4], Tests[1, num4], Tests[0, num5], Tests[1, num5], };
                return Result;
            }


        }
    }
}
