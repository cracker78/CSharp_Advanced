using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KeyRevolverProblemDescription
{
    class KeyRevolverProblemDescription
    {
        static void Main()
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfGun = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>
                (Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Queue<int> locks = new Queue<int>
                (Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int inteligence = int.Parse(Console.ReadLine());

            //int bulletCost = 0;

            //int earned = inteligence;

            int usedBullets = 0;

            int currentSizeOfGun = sizeOfGun;

            //Stack<int> bullets=new Stack<int>();

            while (bullets.Count > 0 && locks.Count > 0)
            {
                currentSizeOfGun -= 1;

                if (bullets.Peek() > locks.Peek())
                {
                    bullets.Pop();
                    Console.WriteLine("Ping!");
                }
                else if (bullets.Peek() <= locks.Peek())
                {
                    bullets.Pop();
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                if (currentSizeOfGun == 0 && bullets.Count>0)
                //&&locks.Count>0
                {
                    Console.WriteLine("Reloading!");
                    currentSizeOfGun = sizeOfGun;
                }

                usedBullets += 1;
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${inteligence - usedBullets * priceOfBullet}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
