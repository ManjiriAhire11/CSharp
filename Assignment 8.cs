using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Use an appropriate collection which holds multiple values of different types.
//Make a note that collection item is readonly

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {

            var tuples = Tuple.Create("Manjiri", 872300, 65.5342, true, false,'A',"Ahire");
          
            Console.WriteLine("All Items are as given below:");
            Console.WriteLine(tuples.Item1);
            Console.WriteLine(tuples.Item2);
            Console.WriteLine(tuples.Item3);
            Console.WriteLine(tuples.Item4);
            Console.WriteLine(tuples.Item5);
            Console.WriteLine(tuples.Item6);
            Console.WriteLine(tuples.Item7);



            Console.ReadLine();
        }
    }
}
