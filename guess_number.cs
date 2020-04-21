using System;

namespace learn2code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра \'Угадай число\'!\nЯ загадал число, а ты попробуй угадать его!");

            Random rnd = new Random();
            int number = rnd.Next(1, 1000);
            int counter = 0;
            while (true)
            {
                Console.WriteLine("\nВведи число: ");
                string guess = Console.ReadLine();
                if (Convert.ToInt32(guess) > number)
                {
                    Console.WriteLine("\nСлишком большое число!");
                    counter++;
                }
                else if (Convert.ToInt32(guess) < number)
                {
                    Console.WriteLine("\nСлишком маленькое число!");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Молодец! Ты угадал!\nПопыток затрачено: {0}", counter);
                    Console.WriteLine("Ещё раз? (y/n)");
                    string choice = Console.ReadLine();
                    if (choice != "y") // игра заканчивается в случае ввода любого символа, кроме 'y'
                    {
                        break;
                    }
                }
            }
        }
    }
}
