using System;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randint1 = new Random();

            int trueResult = 0;
            int i = 0;
            while (i < 11)
            {
                int randomNumber1 = randint1.Next(2, 9);
                int randomowaNumber2 = randint1.Next(2, 9);
                int result = randomNumber1 * randomowaNumber2;

                Console.WriteLine("Ile to: {0} * {1}", randomNumber1, randomowaNumber2);
                int numberGiven = int.Parse(Console.ReadLine());

                if (numberGiven == result)
                {
                    Console.WriteLine("Dobra odpowiedź!");
                    trueResult = trueResult + 1;
                }

                else
                {
                    Console.WriteLine("Zła odpowiedź!");
                }


                Thread.Sleep(1500);
                Console.Clear();
                i++;
                if (i == 10)
                {
                    Console.WriteLine("Ilość poprawnych odpowiedzi: {0}", trueResult);
                    Thread.Sleep(1250);
                    Console.Clear();
                    Console.WriteLine("Czy chcesz rozpocząć jeszcze raz?");
                    String answer = Console.ReadLine();
                    switch (answer.ToLower())
                    {
                        case "tak":
                            Console.Clear();
                            trueResult = 0;
                            i = 0;
                            break;
                        case "nie":
                            break;
                    }
                
                }
                
            }
            
            
        }
    }
}
