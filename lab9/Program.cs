using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            Console.WriteLine("Введите целое число. Х= ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число. Y= ");
            int y = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(x);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                    //("Ошибка! Входная строка имена неверный форман");
            }
            //Код операции
            Console.WriteLine("Введите код операции:");
Console.WriteLine("1-сложение");
Console.WriteLine("2-вычетание");
Console.WriteLine("3-произведение");
Console.WriteLine("4-частное");
           Console.WriteLine($"Ваш выбор: ");
            try
            {
                Console.WriteLine ({ 1,2,3,4});
            }
            catch 
            {
                Console.WriteLine("Нет операций с указанным номером");
            }
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine("Результат: ");
            if(c=='1')
            {
                //1-СЛОЖЕНИЕ
                Console.WriteLine(x + y);
            }
            else
                if(c=='2')
            {
                //2-ВЫЧИТАНИЕ
                Console.WriteLine(x - y);
            }
            else
if (c == '3')
            {
                //3-ПРОИЗВЕДЕНИЕ
                Console.WriteLine(x * y);
            }
            else
                if (c == '4')
            {
               //4-ЧАСТНОЕ
                Console.WriteLine(x / y);
            }
            else { }


            Console.ReadKey();

            
        }
    }
}
