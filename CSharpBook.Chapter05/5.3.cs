using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Chapter05
{
    class Matrix2D
    {
        public static void DisplayMatrix(int[,] A)
        {
            for(int i = 0; i<A.GetLength(0); i++)
            {
                for(int j = 0; j<A.GetLength(1);j++)
                    Console.Write("{0,6}", A[i, j]);
                Console.WriteLine(); 
            }
        }
        static void Main()
        {
            int i, j, sum = 0, t;
            int[,] A = new int[4, 4];
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                    A[i, j] = i * 4 + j + 1;
            Console.WriteLine("原始矩阵：");
            DisplayMatrix(A);
            Console.WriteLine("上三角矩阵：");
            for(i = 0; i< 4; i++)
            {
                for (int k = 0; k < i * 7; k++) Console.Write(" ");
                for (j = i; j < 4; j++) Console.Write("{0,6}", A[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("下三角矩阵：");
            for(i = 0; i<4;i++)
            {
                for (j = 0; j < i + 1; j++)
                    Console.Write("{0,6}", A[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("两条对角线之和：");
            for (i = 0; i < 4; i++)
                sum += A[i,i] + A[i,3 - i];

        }
    }
}
