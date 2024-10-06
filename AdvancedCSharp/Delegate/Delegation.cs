using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Delegate
{
    internal class Delegation
    {
        private delegate string GetAString(); // 宣告委派，委派是一個類型，可以用來宣告變數，並指向一個方法
        public static void Main(String[] args)
        {
            //int x = 40;
            ////string s = x.ToString(); // ToString 方法用以把資料轉換成字串
            ////Console.WriteLine(s);

            //// 使用委派類型 創建instance
            ////GetAString a = new GetAString(x.ToString); // a 是一個委派，指向 x.ToString 方法
            //GetAString a = x.ToString;

            ////string s = a(); // 呼叫委派，委派會呼叫 x.ToString 方法
            //string s = a.Invoke(); // 通過委派呼叫 a 所指向的方法
            //Console.WriteLine(s); // 通過委派呼叫 x.ToString 方法，跟直接呼叫 x.ToString 方法是一樣的


            // -----------------
            // 實例2 使用委派類型作為一個方法的參數
            PrintString method = Method1;
            PrintStr(method);
            method = Method2;
            PrintStr(method);
        }

        private delegate void PrintString();

        // 委派類型可以作為一個方法的參數被傳遞
        static void PrintStr(PrintString print)
        {
            print();
        }

        static void Method1()
        {
            Console.WriteLine("Method1");
        }
        static void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
}
