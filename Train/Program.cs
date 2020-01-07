using System;

namespace Train
{
    class Program
    {
        const int n = 3;
        static void input(Train [] mas)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Пункт назначения: ");
                mas[i].Destination = Console.ReadLine();
                Console.WriteLine("Номер поезда: ");
                mas[i].TrNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Время отправления: ");
                mas[i].DepTime = DateTime.Parse(Console.ReadLine());
            }
        }
        public static void sort(Train[] mas)
        {
            Train tmp;
            for (int i = 0; i < n; i++)
            {
                for (int j = (n - 1); j >= (i + 1); j--)
                    if (mas[j].TrNumber < mas[j - 1].TrNumber)
                    {
                        tmp = mas[j];
                        mas[j] = mas[j - 1];
                        mas[j - 1] = tmp;
                    }
            }
        }
        static void print(Train[] mas)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i+1)+" - поезд       "+ mas[i].Destination +"    "+ mas[i].TrNumber+"    {0:T} " , mas[i].DepTime);
            }
        }
        static void Main(string[] args)
        {
            Train[] array = new Train[n];
            input(array);
            sort(array);
            print(array);
        }
    }
}
