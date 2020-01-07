using System;

namespace DateBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц рождения: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число рождения: ");
            int day = int.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            DateTime dbirthday = new DateTime(today.Year, month,day);
            TimeSpan newData = dbirthday - today;
            Console.WriteLine("До Вашего дня рождения осталось около "+newData.Days+" дней");
            

           

        }
    }
}
