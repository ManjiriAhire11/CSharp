using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an string array of size 5, accept Students name using loop.Print all the member of that array.
//Now try to add one more member at 6th position, If any exception occurs please handle it.



namespace Assignment_9
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] student = new string[5];
            string name;
            try
            {
                Console.WriteLine("Enter the name of students:");

                for (int i = 0; i <= 4; i++)
                {
                    name = Console.ReadLine();
                    student[i] = name;
                }

                Console.WriteLine(" Enter array of students  entered by user: ");

                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine(student[i]);

                }
                name = Console.ReadLine();
                student[6] = name;
            }

             catch (IndexOutOfRangeException error)
                 {
                     Console.WriteLine(error.Message);
                 }

            catch (Exception)
                  {
                      Console.WriteLine("Error occured --- Array size is full, Exception is handled");
                  }
            Console.ReadLine();
        }
    }
}

        
    

