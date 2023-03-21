using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // ввод вывод данных
using System.Text.RegularExpressions; // протранство имён в котором находятся классы регулярных выражений

//C:\Users\ПК\Desktop\example.txt

// входной поток

// выходной поток - из оперативной памяти в выходное устройство - записываем

// Stream (class) - базовый класс для всех потоков

// БАЙТОВЫЕ КЛАССЫ ПОТОКОВ
// FileStream - обеспечевает доступ на уровне байт, читаем байтовый поток
// *если хотим работать с текстовыми файлами (видеть буквы) нужно использовать специальные методы преобразования байтов в строки


// FileStream
/*namespace flows_models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            *//*Write("Введите путь к файлу: ");
            string fpath = ReadLine();
            using (FileStream fs = new FileStream(fpath, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)) // using - проверка на создание, создание и тд закрытие файла
            {
                WriteLine("Введите текст");
                string str = ReadLine();
                byte[] str_byte = Encoding.UTF8.GetBytes(str); // преобразование байтов в тип?? я ничего не понимаю
                fs.Write(str_byte, 0, str_byte.Length);
                WriteLine("OK");
            }*//*

            //////


            Write("Введите путь к файлу: ");
            string fpath = ReadLine();
            using (FileStream fs = new FileStream(fpath, FileMode.Open, FileAccess.Read, FileShare.Read)) // using - проверка на создание, создание и тд закрытие файла
            {

                byte[] str_byte_new = new byte[(int)fs.Length];
                fs.Read(str_byte_new, 0, str_byte_new.Length);
                string str_new = Encoding.Default.GetString(str_byte_new);
                WriteLine(str_new);
            }



        }
    }
}*/



//StreamWriter & StreamReader
/*namespace flows_models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            *//*  Write("Введите путь к файлу: ");
              string fpath = ReadLine();
              using (FileStream fs = new FileStream(fpath, FileMode.Create)) // using - проверка на создание, создание и тд закрытие файла
              {
                  using (StreamWriter sw = new StreamWriter(fs,Encoding.Unicode))
                  {
                      WriteLine("Введите текст");
                      string str = ReadLine();
                      sw.WriteLine(str);
                  }

                  WriteLine("OK");
              }*//*

            //////


            Write("Введите путь к файлу: ");
            string fpath = ReadLine();
            using (FileStream fs = new FileStream(fpath, FileMode.Open)) // using - проверка на создание, создание и тд закрытие файла
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                {

                    WriteLine(sr.ReadToEnd());
                    
                }
            }
        }
    }
}*/


// BINARY READER

/*namespace flows_models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            *//*Write("Введите путь к файлу: ");
            string fpath = ReadLine();
            using (FileStream fs = new FileStream(fpath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read)) // using - проверка на создание, создание и тд закрытие файла
            {
                using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
                {
                    WriteLine("Введите текст");
                    string str = ReadLine();
                    bw.Write(str); // no writeline
                    WriteLine("Введите число");
                    int num = Convert.ToInt32(ReadLine());
                    bw.Write(num);
                    double x = 10.35;
                    bw.Write(x);
                }

                WriteLine("OK");
            }*//*

            //////


            Write("Введите путь к файлу: ");
            string fpath = ReadLine();
            using (FileStream fs = new FileStream(fpath, FileMode.Open)) // using - проверка на создание, создание и тд закрытие файла
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    WriteLine(br.ReadString());
                    WriteLine(br.ReadInt32());
                    WriteLine(br.ReadDouble());
                }

                //WriteLine("OK");
            }
        }
    }
}*/

// РЕГУЛЯРНЫЕ ВЫРАЖЕНИЯ - (телефон или почта к примеру)
// phone - +7-***-***-**-**

namespace flows_models
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* string phone_pattern = @"^\+\d-\d{3}-\d{3}-\d{2}-\d{2}$"; // снимает экранирование
            string phone = ReadLine();
            Regex r_phone = new Regex(phone_pattern); // строка стала паттерном 
            WriteLine(r_phone.IsMatch(phone) ? "correct" : "incorrect"); // метод проверки нашей строки и регулярки
*/
            //email ****.******.********@*******.***.***.**
            string email_pattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@([a-z0-9_-]+\.)*[a-z]{2,4}$";
            string email = ReadLine();
            Regex r_email = new Regex(email_pattern); // строка стала паттерном 
            WriteLine(r_email.IsMatch(email) ? "correct" : "incorrect");

        }
    }
}