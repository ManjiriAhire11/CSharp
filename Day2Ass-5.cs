using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Title:

//Accept key as "No. of developers" prefering programing language and Value as "Progrmmming lanugage" in preferred collection.
//basedon on count of developers preferring programming language give ranking to that programming language.
//For example: 1200 - CSharp, 1400 - Python, 456 - Java, 1900 - javascript, 1500 - SQL





namespace Day2Ass_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of developers and programming launguages");
            List<Tuple<int, string>> list = new List<Tuple<int, string>>(p);
            int q = 0;
            while(q<p)
            {
                string line = Console.ReadLine();
                string[] temp = line.Split(' ');
                list.Add(new Tuple<int, string>(int.Parse(temp[0]), temp[1]));
                q++;
            }
            list.Sort();
            q = 1;
            for (int i=p-1;  i>=0; i--)
            {
                Console.WriteLine("Rank"+" "+list[i].Item2);
                q++;


            }
            Console.ReadLine();
        }

    }
}
