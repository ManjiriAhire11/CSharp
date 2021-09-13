using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Title:
//Create an array of 10 numbers and print the 3rd highest no.


namespace Assignment_11
{
    class GFG
    {
        static void thirdLargest(int[] arr,
                                 int arr_size)
        {
            
            if (arr_size < 3)
            {
                Console.Write(" Invalid Input ");
                return;
            }

           
                   int first = arr[0];
                   for (int i = 1; i < arr_size; i++)
                   if (arr[i] > first)
                   first = arr[i];

            
                  int second = -int.MaxValue;
                  for (int i = 0;i < arr_size; i++)
                  if (arr[i] > second &&  arr[i] < first)
                  second = arr[i];

            
                 int third = -int.MaxValue;
                 for (int i = 0; i < arr_size; i++)
                 if (arr[i] > third &&  arr[i] < second)
                 third = arr[i];

                 Console.Write("The third Largest " + "element is " + third);
                 Console.ReadLine();

        }
       

       
                 public static void Main()
                 {
                       int[] arr = {12, 15, 10, 34, 16};
                       int n = arr.Length;
                       thirdLargest(arr, n);
                  }
    }
}


