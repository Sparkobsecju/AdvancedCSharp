using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Delegate
{
    internal class FunctionDelegation
    {
        public static void Main(string[] args)
        {
            Func<int> a;
            a = Test1; // Func中的Generic Type制定的是 方法回傳值的型別
            //Console.WriteLine(a());

            Func<string, int> b; // 最後的類型是回傳值的型別，前面的是參數的型別
            b = Test2;
            //Console.WriteLine(b("HelloWorld")); // return 100

            Func<string, string, int> c;
            c = Test3;
            //Console.WriteLine(c("Hello", "World")); // return 200

            Func<int, int, int> d;
            d = Test4; // Func中最後一個必須是回傳值的型別，同時參數的型別也要依序對應，不然會出錯
            // 參數的類型數量為 0 ~ 16個(和Action一樣)，加上回傳值的型別，最多可以有17個型別
            int result = d(1, 5);
            Console.WriteLine(result);

        }
        static int Test4(int i, int j) { return i + j; }
        static int Test3(string str1, string str2) {
            Console.Write($"將兩個字串相連接，輸出結果為：{str1} + {str2}");
            Console.WriteLine(", 並回傳200!");
            return 200; 
        }
        static int Test2(string str) { return 100; }
        static int Test1() { return 1; }
    }
}
