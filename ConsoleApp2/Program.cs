using System;
using System.Collections.Generic;
using System.Linq;

namespace encryption_console_prog
{
    public class Program
    {
        //________________Method to input the key________________
        static public string InputKey()
        {
            Console.Write("Enter a key of 10 different digits: ");
            string key = Console.ReadLine();

            bool isItDigit = key.All(char.IsDigit);
            bool hasRepeatedNumbers = key.Length != key.Distinct().Count();

            while (key.Length != 10 || !isItDigit || hasRepeatedNumbers)
            {
                Console.Write("Error, please enter a key of 10 different digits: ");
                key = Console.ReadLine();

                isItDigit = key.All(char.IsDigit);
                hasRepeatedNumbers = key.Length != key.Distinct().Count();
            }
            return key;
        }

        //________________Method to input the message________________
        static public string InputMessage()
        {

            Console.WriteLine("Enter your message: ");
            string SentMSG = Console.ReadLine();
            bool isItDigit = SentMSG.All(char.IsDigit);
            while (!isItDigit)
            {
                Console.Write("Error, You can only send numbers. Try again: ");
                SentMSG = Console.ReadLine();
                isItDigit = SentMSG.All(char.IsDigit);
            }
            return SentMSG;
        }

        //________________Method to encrypt the message________________
        static public string encryptMSG(string key, string SentMSG)
        {
            string result = "";

            Dictionary<int, char> My_dict = new Dictionary<int, char>();

            for (int i = 0; i < 10; i++)
               My_dict.Add(i, key[i]);

            foreach (var i in SentMSG)
                result += My_dict[int.Parse(i.ToString())];

            return result;
        }

        //________________Driver code________________
        static void Main(string[] args)
        {
            while(true)
            {
                string key = InputKey();
                string SentMSG = InputMessage();
                string result = encryptMSG(key, SentMSG);

                Console.WriteLine("the encrypted message is:\n{0}", result);
                Console.WriteLine("______________________________________");
            }
        }

        //________________methods used in GUI_________________
        static public string CleanText(string s)
        {
            foreach (var c in s)
                if (!char.IsDigit(c)) //cleans the text from non-numeric values
                    s = s.Replace(c.ToString(), "");
            return s;
        }

        static public string CleanDuplicate(string s)
        {
            for (int i = s.Length - 1; i > 0; i--)
                if (s.Substring(0, i).Contains(s[i]))
                    s = s.Remove(i, 1);
            return s;
        }
    }
}