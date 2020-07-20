using System;
using System.Collections;
using System.Collections.Generic;

namespace DataReversal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a word you would like to reverse: ");
            string userEntry = Console.ReadLine();

            Console.WriteLine(Reverse(userEntry));
        }

        static string Reverse(string userEntry)
        {
            string flipUser = "";

            Stack flip = new Stack();

            for (int index = 0; index < userEntry.Length; index++)
            {
                char letter = (char)userEntry[index];
                flip.Push(letter);
            }
            
            foreach (char entry in flip) //Print user input in reverse
            {
                flipUser = flipUser += (char)entry;
            }

            return flipUser;
        }
    }
}
