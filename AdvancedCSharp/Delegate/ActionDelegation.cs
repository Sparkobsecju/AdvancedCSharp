using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Delegate
{
    internal class ActionDelegation
    {
        public static void Main(string[] args)
        {
            int x = 100;
            //Action a = x.ToString; // Compile time error 因為 x.ToString 是有回傳值的方法

            //Action a = PrintString; // Action 是系統預設的 delegate，不需要自己定義
            // 可以指向一個沒有參數也沒有回傳值的方法

            Action<int> a; // 定義一個 Action delegate，可以指向一個有 int 參數，沒有回傳值的方法
            //a = PrintString; // 這樣是不行的，因為 PrintString 沒有參數
            a = Print; // 這樣是可以的，因為 Print 有一個 int 參數

            Action<string> b;
            b = PrintBString; // 系統會自動尋找Overload的對應方法

            Action<int, int> c;
            c = PrintDoubleIntCalculate;

            c(34, 66);

            Action<int, int, int, string, bool, string> d; // 最多可以有16個參數
            // Summary: Action可以後面通過Generic的方式指定參數的數量，最多可以有16個參數
            // 參數的類型可以是任何類型，但是回傳值只能是void
        }
        static void PrintDoubleIntCalculate(int i1, int i2)
        {
            Console.WriteLine(i1 + i2);
        }
        static void PrintBString() { Console.WriteLine("No Parameter"); }
        static void PrintBString(String str)
        {
            Console.WriteLine(str);
        }
        static void Print(int i)
        {

        }

        static void PrintString()
        {
            Console.WriteLine("Hello World");
        }
    }
}
