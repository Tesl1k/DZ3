using System;

namespace consoleapp
{
    class Program
    {        
        public static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
                intList.Add(random.Next(-100, 100));

            stringList.Add("Красный");
            stringList.Add("Омлет");
            stringList.Add("Забор");
            stringList.Add("Доска");
            stringList.Add("Кошка");

            Console.WriteLine("Целые числа");

            for (int i = 0; i < intList.Length; i++)
                Console.Write($"{intList[i]} ");

            Console.WriteLine("");
            Console.WriteLine("Список целых чисел:");

            for (int i = 0; i < stringList.Length; i++)
                Console.Write($"{stringList[i]} ");

            Console.WriteLine("");
 
            try
            {
                intList.RemoveAt(random.Next(-1, 12));
                stringList.RemoveAt(random.Next(-1, 6));

                Console.WriteLine("Список целых чисел:");

                for (int i = 0; i < intList.Length; i++)
                    Console.Write($"{intList[i]} ");

                Console.WriteLine("");
                Console.WriteLine("Список целых чисел:");

                for (int i = 0; i < stringList.Length; i++)
                    Console.Write($"{stringList[i]} ");

                Console.WriteLine("");
            }
            catch
            {
                Console.WriteLine("Ошибка при удалении: индекс вне допустимого диапазона");
            }
        }
    }
}
