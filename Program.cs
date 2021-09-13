using System;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int z = rand.Next(1, 101);
            int y=0;
            while(true)
            {
                Console.Write("Gissa: ");
                string str = Console.ReadLine();
                int x = int.Parse(str);
                if(x > z)
                {
                    Console.WriteLine("Gissning för hög");
                    y++;
                }
                else if (x < z)
                {
                    Console.WriteLine("Gissning för låg");
                    y++;
                }
                else if (x == z)
                {
                    Console.WriteLine("Rätt Gissning!");
                    Console.WriteLine("Antal gissningar: " + y++);
                    break;
                }
            }
        }
    }
}
