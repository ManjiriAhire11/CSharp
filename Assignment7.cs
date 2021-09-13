using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
     public   static void Main(string[] args)
        {


           
                NamesDisplay("Manjiri","Ashu");
                NamesDisplay("Neha", "Paritosh", "Riya", "Madhavi", "Kunal");
                NamesDisplay("Kritika","Samidha","Dipesh","Pradnesh","Ritesh");

                Console.ReadLine();

            }

            private static void NamesDisplay(params string[] parameters)
            {
                Console.WriteLine("****Students names are as follow****");

                foreach (var item in parameters)
                {
                    Console.WriteLine(item);
                }

            }
        }

    }



           