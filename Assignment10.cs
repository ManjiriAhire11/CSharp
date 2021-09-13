using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a student class and include below properties:
//StudentID int, FullName string, CourseName string, PhoneNo string
// Accept of Student's  details 5 entries at least and print as a summary.....



namespace Assignment_10
{
    class Program
    {
        static void Main(string[] args)
        {

            int value = 0;
            int[] StuID = new int[10];
            string[] StudFullName = new string[200];
            string[] CourseName = new string[200];
            string[] PhoneNum = new string[10];
            
            Console.WriteLine("Enter how many entries you want:");
            value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <value; i++)
            {
                Console.WriteLine("Student_ID:");
                int ID = Convert.ToInt32(Console.ReadLine());
                StuID[i] = ID;

                Console.WriteLine("Student Full Name:");
                string FName = Console.ReadLine();
                StudFullName[i] = FName;

                Console.WriteLine("Course Name:");
                string CName = Console.ReadLine();
                CourseName[i] = CName;

                Console.WriteLine("Ph. Number:");
                string PhNumber = Console.ReadLine();
                PhoneNum[i] = PhNumber;
            }

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("ID: {0}", StuID[i]);
                Console.WriteLine("FullName: {0}", StudFullName[i]);
                Console.WriteLine("CourseName: {0}", CourseName[i]);
                Console.WriteLine("PhoneNo: {0}", PhoneNum[i]);

            }

            Console.Read();
        }
    }
}

        
