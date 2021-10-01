using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Arva ära number ühest kümneni:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled mängu võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number. Jäänud on {3 - i} katset.");
                if(i == 3)
                    {
                        Console.WriteLine($"Oled kaotanud :( Mängu võitis arvuti!");
                    }                    
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
