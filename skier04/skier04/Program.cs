using System;

namespace skier04
{
    class Program
    {
        //Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня.
        //Определить, какой суммарный путь он пробежал за первые 7 дней тренировок.

        public decimal Distance(decimal firstDayDistance, decimal koefficient, int days)
        {
            decimal summa = 0;
            
            for (int i = 0; i < days; i++)
            {
                summa = firstDayDistance + koefficient * summa;
                Console.WriteLine("Sum of " + (i + 1) + " days is " + summa);
                Console.ReadKey();
            }
            return summa;
        }

        static void Main(string[] args)
        {
            decimal firstDayDistance = 10;
            decimal koefficient = (decimal)1.1;
            int days = 7;

            decimal resultat;
            Program res = new Program();
            resultat = res.Distance(firstDayDistance, koefficient, days);
        }
    }
}


