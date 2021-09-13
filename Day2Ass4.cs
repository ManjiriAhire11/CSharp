using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Title:
//Create an enum with  below values, accept value from user and using switch case show respective Day
  //  Enum :Sun, Mon, Tue, Wed, Thur, Fri, Sat

namespace Day2Ass_4
{
    class Program
    {
        enum weekday { Sun,Mon,Tue,Wed,Thur,Fri,Sat};
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Day:");
            int days = int.Parse(Console.ReadLine());
            weekday day = (weekday)days;

            switch (day)
            {
                case weekday.Sun:
                    Console.WriteLine("Sunday");
                    break;

                case weekday.Mon:
                    Console.WriteLine("Monday");
                    break;

                case weekday.Tue:
                    Console.WriteLine("Tuesday");
                    break;

                case weekday.Wed:
                    Console.WriteLine("Wednesday");
                    break;

                case weekday.Thur:
                    Console.WriteLine("Thursday");
                    break;

                case weekday.Fri:
                    Console.WriteLine("Friday");
                    break;


                case weekday.Sat:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
                    Console.ReadLine();
            


        }
    }
}