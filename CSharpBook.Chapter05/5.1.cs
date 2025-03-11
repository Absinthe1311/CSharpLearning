//namespace CSharpBook.Chapter05
//{
//    internal class Students1DArray
//    {
//        static void Main(string[] args)
//        {
//            int[] mark = new int[100];
//            Random rNum = new Random();
//            int i, sumMark = 0, avgMark, overAvg = 0;
//            for(i = 0; i < 100; i++)
//            {
//                mark[i] = rNum.Next(101);
//                sumMark += mark[i]
//            }
//            avgMark = sumMark / 100;
//            for(i = 0; i < 100; i++)
//            {
//                if (mark[i] > avgMark) overAvg++;
//            }
//            Console.WriteLine("100个学生的成绩，平均成绩={0},高于平均成绩的人数={1}", avgMark, overAvg);
//        }
//    }
//}
