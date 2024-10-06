using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Practice
{
    internal class TestStringBuilder
    {
        public static void Main(string[] args)
        {
            // System.Text.StringBuilder
            StringBuilder sb = new StringBuilder("www.helloworld.com");
            StringBuilder sb2 = new StringBuilder(20);
            StringBuilder sb3 = new StringBuilder("www.helloworld.com", 100);
            sb3.Append("/xxx.html"); // Hight performance because it doesn't create a new string
            Console.WriteLine(sb3);
            string s = "www.helloworld.com";
            s = s + "/xxx.html"; // Low performance because it creates a new string
            Console.WriteLine(s);


            StringBuilder stringBuilder = new StringBuilder("www.helloworld.com", 100);
            stringBuilder.Insert(0, "http://");
            Console.WriteLine(stringBuilder);
            string keyword = "hello";
            stringBuilder.Remove(
                stringBuilder.ToString().IndexOf(keyword),
                keyword.Length);
            Console.WriteLine(stringBuilder);

            StringBuilder sb4 = new StringBuilder("www.helloworld.com");
            sb4.Replace(".", "->");
            Console.WriteLine(sb4);

        }
    }
}
