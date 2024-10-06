using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdvancedCSharp.Practice
{
    internal class TestRegularExpression
    {
        public static void Main(string[] args)
        {
            //string s = "I am goalden dog";
            //string result = Regex.Replace(s, "^", "開始："); // 搜尋字串 符合正規表達式的情況
            //// 然後把所有符合的位置，替換成指定的字串
            //Console.WriteLine(result);
            //string result2 = Regex.Replace(s, "$", "結束");
            //Console.WriteLine(result2);


            //string s = Console.ReadLine();
            //bool isMatch = true; // 預設表示 s 是一個合法的密碼(全都是數字)
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] < '0' || s[i] > '9')
            //    {
            //        isMatch = false;
            //        break;
            //    }
            //}
            //if (isMatch)
            //{
            //    Console.WriteLine("密碼合法");
            //}
            //else
            //{
            //    Console.WriteLine("密碼不合法");
            //}
            //string pattern = @"^\d*$"; // Regular Expression
            ////string pattern = @"\d"; // 只要有一個數字就可以了
            //string pattern1 = @"a949";


            //bool isMatch = Regex.IsMatch(s, pattern);

            //Console.WriteLine(isMatch);


            //string pattern = @"^\W*$";
            //bool isMatch = Regex.IsMatch(s, pattern);
            //Console.WriteLine(isMatch);

            //string str = "I am a cat.";
            //string pattern = @"[^ahou]";
            //string tmp = Regex.Replace(str, pattern, "-");
            //Console.WriteLine(tmp);

            //string qq = "234234";
            //string qq2 = "234234234234234";
            //string qq3 = "d4234234";
            //string pattern = @"^\d{5,12}$";
            //Console.WriteLine(Regex.IsMatch(qq, pattern));
            //Console.WriteLine(Regex.IsMatch(qq2, pattern));
            //Console.WriteLine(Regex.IsMatch(qq3, pattern));


            //string s = "34((*&SDFlkj 道路設計費";
            //string pattern = @"\d|[a-z]|[A-Z]";
            //MatchCollection collection =  Regex.Matches(s, pattern);
            //foreach(Match item in collection)
            //{
            //    Console.Write(item.ToString() + " "); // 呼叫 ToString()，會輸出符合的字串
            //}

            //string s = "dshfuisd,afiods:dfjdsof;sdhoiu.dsd,:;.59487";
            ////string pattern = @"[,:;.]";
            ////string pattern = @"[,][:][;][.]";
            //string pattern = @"[,]|[:]|[;]|[.]";

            //string[] resultArray = Regex.Split(s, pattern);
            //foreach (String str in resultArray)
            //{
            //    Console.Write(str + " \n");
            //}

            // 重複 多字元 使用 (abcd){n} 進行分類
            //string inputStr = Console.ReadLine();
            //string strGroup = @"(ab\w{2}){2}"; // == "ab\w{2}ab\w{2}"
            //Console.WriteLine("分類字元重複2次替換為5555，結果為" +
            //Regex.Replace(inputStr, strGroup, "5555"));

            //-------------------------------------------------------------------------
            // IP Address
            //0-255.0-255.0-255.0-255
            // 20-4 0-9
            // 25 0-5
            // 0-1 0-9 0-9

            /**
              
              @*^(
              (
              (
              2[0-4]\d
              |
              25[0-5]
              |
              [01]?\d\d?)
              \.
              ){3}
              (2[0-4]\d|35[0-5]|[01]?\d\d?))$
              
             */
            string pattern = @"^(((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?))$";
            while(true)
            {

                Console.WriteLine("請輸入IP地址");
                string inputStr = Console.ReadLine();
                if (inputStr.Equals("end")) { break; }

                if (Regex.IsMatch(inputStr, pattern))
                    Console.WriteLine(Regex.IsMatch(inputStr, pattern) + "\n---------");
                else
                    Console.WriteLine("輸入的IP地址不合法\n---------");
            }
            // -------------------------------------------------------------------------
            
        }
    }
}

// @"^(((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?))$"