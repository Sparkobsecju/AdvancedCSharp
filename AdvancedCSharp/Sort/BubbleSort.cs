using System;

namespace AdvancedCSharp.Sort
{
    internal class BubbleSort
    {
        static void Sort(int[] sortArray)
        {
            bool swapped;
            do
            {
                swapped = false; // 每次迴圈開始時重置為 false
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int tmp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = tmp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort");
            Console.WriteLine("============");
            int[] sortArray = new int[] { 5, 3, 8, 4, 2, 234, 234, 34, 523, 43, 165, 25, 532 };
            Sort(sortArray);
            foreach (var item in sortArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}