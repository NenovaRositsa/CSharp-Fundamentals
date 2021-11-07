using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            string pattern = @" \b[a-z|0-9]+[\.\-_]*?[0-9]*?\.*?[a-z]*[\.\-_]*?[0-9]*?@[a-z\-*?a-z*?]+\.[a-z\-*?a-z*?]+\.*?[a-z\-*?a-z*?]+\b";

            MatchCollection matchedEmails = Regex.Matches(input, pattern);

            foreach (Match email in matchedEmails)
            {
                Console.WriteLine(email);
            }


        }
    }
}
