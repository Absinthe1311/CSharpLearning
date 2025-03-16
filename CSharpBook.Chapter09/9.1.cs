//using System;
//namespace CSharpBook.Chapter09
//{
//    delegate void D(int x); //声明委托
//    class C
//    {
//        public static void M1(int i) { Console.WriteLine("C.M1:" + i); }
//        public static void M2(int i) { Console.WriteLine("C.M2:" + i); }
//        public void M3(int i) { Console.WriteLine("C.M3:" + i); }
//    }
//    class Test
//    {
//        static void Main()
//        {
//            D d1 = new D(C.M1);     //使用new关键字，创建委托对象，指向类静态方法
//            d1(-1);
//            D d2 = C.M2;            //使用赋值运算符，创建委托对象，指向类的静态方法
//            d2(-2);
//            C obj = new C();        //创建C的实例对象
//            D d3 = new D(obj.M3);   //使用new关键字，创建委托对象，指向类的实例方法
//            d3(-3);
//            Console.ReadKey();
//        }
//    }
    
//}
