using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Practice
{
    internal class TestString
    {
        public static void Main(string[] args)
        {
            string s = "www.helloworld.com"; // 使用 string 類型去儲存字串類型 
                                             //int length = s.Length;
                                             //Console.WriteLine(length);

            //if (s == "www.helloworld.com")
            //{
            //    Console.WriteLine("相同");
            //}
            //else
            //{
            //    Console.WriteLine("不相同");
            //}
            //Console.Write(length);
            //s = "http://" + s;
            //Console.WriteLine(s);
            //char c = s[3];
            //Console.WriteLine(c);
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}

            //string s = "snake";
            //int res = s.CompareTo("stake");
            // 當兩字串相等時回傳0，當s在字母中排序在前時回傳負數，反之則回傳正數
            //Console.WriteLine(res);


            //string newString = s.Replace(".", "-");
            //string newString2 = s.Replace("world", "csharp");
            //newString2 = newString2.Replace(".", "-----");
            //Console.WriteLine($"s:\n\t{s}, \nnewString:\n\t{newString}");
            //Console.WriteLine($"newString2:\n\t{newString2}");

            //string[] strArray = s.Split('.');
            //foreach (var item in strArray)
            //{
            //    Console.WriteLine(item);
            //}

            //string str = s.Substring(4, 13);
            //Console.WriteLine(str);

            //string str = s.ToUpper();
            //Console.WriteLine(s.ToUpper());
            string tmp = "   hi test trim function   ";
            Console.WriteLine(tmp);
            Console.WriteLine(tmp.Trim());

            // 可使用該方法判斷當前字串是否包含指定字串，若有則回傳該字串的索引位置，反之則回傳-1
            Console.WriteLine(s.IndexOf("world")); 
        }
    }
}
