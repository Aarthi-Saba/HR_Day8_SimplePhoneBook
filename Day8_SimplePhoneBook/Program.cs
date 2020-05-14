/*Objective
Today, we're learning about Key-Value pair mappings using a Map or Dictionary data structure. Check out the Tutorial tab for learning materials and an instructional video!

Task
Given 'N' names and phone numbers, assemble a phone book that maps friends' names to their respective phone numbers. 
You will then be given an unknown number of names to query your phone book for. 
For each name queried, print the associated entry from your phone book on a new line in the form name=phoneNumber; 
if an entry for name is not found, print Not found instead.

Note: Your phone book should be a Dictionary/Map/HashMap data structure.

Input Format

The first line contains an integer,'N' , denoting the number of entries in the phone book.
Each of the  subsequent lines describes an entry in the form of 2 space-separated values on a single line. 
The first value is a friend's name, and the second value is an 8-digit phone number.

After the n lines of phone book entries, there are an unknown number of lines of queries. Each line (query) contains a  to look up, 
and you must continue reading lines until there is no more input.

Note: Names consist of lowercase English alphabetic letters and are first names only.

Constraints

Output Format

On a new line for each query, print Not found if the name has no corresponding entry in the phone book; otherwise, print the full  and  in the format name=phoneNumber.

Sample Input

3
sam 99912222
tom 11122222
harry 12299933
sam
edward
harry

Sample Output
sam=99912222
Not found
harry=12299933
Explanation
*/

using System;
using System.Collections.Generic;

namespace Day8_SimplePhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PhoneBook Application");
            Console.WriteLine("Please enter total number of inputs for the phonebook");
            int.TryParse(Console.ReadLine(), out int total);
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            for(int i=1; i <= total; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                phoneBook.Add(input[0], input[1]);
            }
            bool flag = true;
            while (flag)
            {
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    flag = false;
                    break;
                }
                if (! phoneBook.ContainsKey(name))
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    Console.WriteLine("{0}={1}",name,phoneBook[name]);
                }
            }
        }
    }
}
