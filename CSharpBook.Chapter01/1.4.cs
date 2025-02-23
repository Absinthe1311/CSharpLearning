//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpBook.Chapter01
//{
//    public class Point
//    {
//        public int x, y;
//        public Point(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//        public double Distance(Point p)
//        {
//            return Math.Sqrt((x-p.x) * (x - p.x) + (y - p.y) * (y - p.y));
//        }
//    }
//    class PointTest
//    {
//        static void Main()
//        {
//            Point p1 = new Point(0, 4);
//            Point p2 = new Point(3, 0);
//            double dist = p1.Distance(p2);
//            Console.WriteLine("点1的坐标为:("+p1.x+ "," + p1.y + ")");
//            Console.WriteLine("点2的坐标为:(" + p2.x + "," + p2.y + ")");
//            Console.WriteLine("两点之间的距离为:" + dist);
//        }
//    }
//}
