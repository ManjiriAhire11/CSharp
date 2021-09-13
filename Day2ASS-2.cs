using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Accept no from user and write table as follows. For example user types 19 then output should be:


namespace Day2ASS_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "*" + i+"="+ num * i);
                Console.ReadLine();

            }

        }
    }
}
