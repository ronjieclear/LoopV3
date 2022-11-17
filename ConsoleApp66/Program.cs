using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int ulit = 0;
            Console.WriteLine("== this is a loop program == ");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("How many times do you want to print your name: ");
            ulit = int.Parse(Console.ReadLine()); //jhon carlo
                                                  //iteration  = isang ikot or isang ulit

            int i = 1;
            do
            {
                Console.WriteLine(name);
                i++;
                if (i==3)   //if the guess == password
                {
                    //break;
                    goto part2;
                }
            } while (i<=ulit);

            part1:  //label
            Console.WriteLine("Part 1");
            part2:
            Console.WriteLine("Part 2");






            /*            //while loop
                        int i = 1;
                        int y = 0;
                        while (i <= ulit)
                        {
                            Console.WriteLine(name);
                            i++; // i = i +1;

                            while (y < ulit)
                            {
                                Console.WriteLine(y);
                                y = y + 2;
                            }
                        }

                        for (int p=1;p<=ulit;p++)
                        {
                            Console.WriteLine("malinao");
                            for (int j=10;j>ulit;j=j-3)
                            {
                                Console.WriteLine(j);
                            }
                        }*/




            Console.ReadLine();


        }
    }
}
