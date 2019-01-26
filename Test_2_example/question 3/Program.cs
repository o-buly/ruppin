using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeGenerator generator;
            generator = new PrimeGenerator();
            int prime = generator.NextPrime();
            Console.WriteLine("A prime : " + prime.ToString());
            generator.SetPosition(10);
            prime = generator.NextPrime();
            Console.WriteLine("A prime : " + prime.ToString());
            prime = generator.NextPrime();
            Console.WriteLine("A prime : " + prime.ToString());
            prime = generator.NextPrime();
            Console.WriteLine("A prime : " + prime.ToString());
        }
        //Class Prime
        public class PrimeGenerator
        {
            int Position;
            public PrimeGenerator()
            {
                this.Position = 1;
            }

            public void SetPosition(int NewPosition)
            {
                this.Position = NewPosition;
            }

            //Returns current position
            public int GetPosition()
            {
                return Position;
            }

            //Returns the next prime of the generator.
            //The next prime is the first number which is 
            //prime after the //position value
            public int NextPrime()
            {
                if (Position <= 1)
                {
                    this.Position = 2;
                    return Position;
                }
                Position++;
                for (int i = 2; i <= Position / 2; i++)
                {
                    if (Position % i == 0)
                    {
                        Position++;
                        i = 2;
                    }
                }
                return Position;
            }
        }
    }
}
