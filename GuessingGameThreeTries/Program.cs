using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);

            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("Vali number 1-10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud!");
                    i = 3;
                }
                else
                {
                    i = i + 1;
                    if(i < 3)
                    {
                        Console.WriteLine($"Proovi uuesti. {3 - i} katsed on jäänud.");
                    }
                    else
                    {
                        Console.WriteLine("Arvuti on võitnud.");
                    }
                    
                }
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
