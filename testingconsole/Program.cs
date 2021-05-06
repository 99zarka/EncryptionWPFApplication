using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "wqqwweerrttyryq";
            Console.WriteLine(s);
            Console.WriteLine(s.Contains("q"));

            for (int i = s.Length - 1; i > 0; i--)
                if (s.Substring(0, i).Contains(s[i]))
                    s=s.Remove(i, 1);

                
            //for (int i=0;i< s.Length-1;i++)
            //    if (s.Substring(i+1, s.Length).Contains(s[i]))
            //        s.Remove(i, 1);
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
