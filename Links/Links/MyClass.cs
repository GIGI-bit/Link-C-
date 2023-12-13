using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Links
{
    public class MyClass
    {
        public void Space(string str)
        {
            string result = "";
            foreach (char c in str)
            {
                result += c + "_";
            }

            Console.WriteLine(result);
        }
        public void Reverse(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            Console.WriteLine(result);
        }
    }
}
