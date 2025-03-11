//namespace CSharpBook.Chapter04
//{
//    internal class Sequence
//    {
//        static void Main(string[] args)
//        {
//            double a, b, c, p, area;
//            Console.Write("请输入三角形的边A:");
//            a = double.Parse(Console.ReadLine());
//            Console.Write("请输入三角形的边B:");
//            b = double.Parse(Console.ReadLine());
//            Console.Write("请输入三角形的边C:");
//            c = double.Parse(Console.ReadLine());
//            Console.WriteLine("三角形的三边分别为：{0}、{1}、{2}", a, b, c);
//            p = (a + b + c) / 2; //周长的一半
//            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //海伦公式
//            Console.WriteLine("三角形的面积为：{0}", area);
//            Console.ReadKey();

//        }
//    }
//}
