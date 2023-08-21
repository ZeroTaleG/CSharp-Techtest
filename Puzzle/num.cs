using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    class num
    {
        static async void Number()
        {
            int number = 1;
            int checkloop = 1;
            for(int loop=1;loop <= 99;){
                if(number == 100)
                {
                    number = 1;
                    loop = loop + 1;
                    checkloop = loop;
                    await Task.Delay(1000);
                }
                else
                {
                    Console.WriteLine("Loop " + loop + ":" + number);
                    number = number + 1;
                    await Task.Delay(1000);
                }
            }
            if(checkloop != 100)
            {
                Console.WriteLine("PROGRAM FAILED!!");
            }
            else
            {
                Console.WriteLine("Ended Successfuly");
            }
        }

        static void Main(string[] args)
        {
            num.Number();
            Console.ReadKey();
        }
    }
}
