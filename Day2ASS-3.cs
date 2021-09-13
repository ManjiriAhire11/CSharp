using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Title:
//Add values following fields from user in dictionary. After inserting ask user's input to accept key to delete data from dictionary.
//If key does not exist then prompt message that Key does not exist in collection. If key exists then delete it.


namespace Day2Ass_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> D = new Dictionary<string, string>
            {
                { "key1", "january" },
                { "key2", "february" },
                { "key3", "March" },
                { "key4", "April" },
                { "key5", "May" },
                { "key6", "June" },
                { "key7", "July" },
                { "key8", "August" },
                { "key9", "September" },
                { "key10", "octomber" },
                { "key11", "november" },
                { "key12", "December" },


            };
            string key = "key11";
            bool keyExists = D.ContainsKey(key);
            if (keyExists)

            {
                Console.WriteLine("Key is found", key);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid key does not found", key);
                Console.ReadLine();
            }
        }
    }
}
