using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Arva ära number ühest kümneni:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled mängu võitnud!");
                    loopActive = false;
                }
                else
                {
                    i++; //i = i + 1;
                    Console.WriteLine("Vale number. Proovi uuesti!");
                    Console.WriteLine($"Oled vale numbri {i} korda sisestanud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
