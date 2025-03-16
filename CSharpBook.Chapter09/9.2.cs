//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpBook.Chapter09
//{
//    delegate void D(int[] A); //声明委托
//    class ArraySort
//    {
//        public static void DisplayArray(int[] A)    //打印数组内容
//        {
//            foreach (int i in A)  Console.Write("{0,5}", i); Console.WriteLine(); 
//        }
//        public static void GeneralSort(int[] A, D sort) //通用排序程序
//        {
//            sort(A);
//            Console.WriteLine("升序数组:");DisplayArray(A);
//        }
//        public static void BubbleSort(int[] A) //冒泡算法
//        {
//            int i, t;
//            int N = A.Length;
//            for(int loop = 1; loop <= N-1; loop++)
//            {
//                for(i = 0; i< N-1-loop; i++)
//                    if (A[i] > A[i+1])
//                    { t = A[i]; A[i] = A[i + 1]; A[i + 1] = t; }
//            }
//        }
//        public static void SelectSort(int[] A)
//        {
//            int i, t, MinI;
//            int N = A.Length;
//            for (int loop = 0; loop <= N - 2; loop++)
//            {
//                MinI = loop;
//                for (i = loop; i <= N - 1; i++)
//                    if (A[i] < A[MinI]) MinI = i;
//                t = A[loop]; A[loop] = A[MinI]; A[MinI] = t;
//            }
//        }
//        static void Main()
//        {
//            int[] A = new int[10];
//            Random rNum = new Random();
//            for (int i = 0; i < 10; i++) A[i] = rNum.Next(101);
//            Console.Write("原始数据：");DisplayArray(A);
//            D d1 = new D(ArraySort.BubbleSort);
//            Console.Write("冒泡算法--"); GeneralSort(A, d1);
//            D d2 = new D(ArraySort.SelectSort);
//            Console.Write("选择算法--");GeneralSort(A, d2);
//        }
//    }
//}
