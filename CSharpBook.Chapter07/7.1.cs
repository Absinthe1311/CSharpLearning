//namespace CSharpBook.Chapter07
//{
//    class Counter
//    {
//        public int number; //实例字段
//        public static int count; //静态字段
//        public Counter()
//        {
//            count = count + 1; number = count;
//        }
//        public void showInstance()   //实例方法
//        {
//            Console.WriteLine("object{0}:", number);
//            Console.WriteLine("count = {0}", count);
//        }
//        public static void showStatic()
//        {
//            //Console.Write("object{0} :",number); //错误，静态方法不能使用实例字段
//            Console.WriteLine("count = {0}", count); //静态方法使用静态字段
//        }
//    }
//    class CounterTest
//    {
//        public static void Main()
//        {
//            Counter c1 = new Counter();
//            c1.showInstance(); //使用对象调用实例方法
//            //c1.showStatic(); //不能使用对象调用静态方法
//            Console.Write("object{0}:", c1.number); //使用对象引用实例字段
//            //Console.Write("object{0}:",Counter.number); //不能使用类名引用实例字段
//            //Console.WriteLine("count = {1}", c1.count); //不能通过对象引用静态字段
//            Counter.showStatic();   //使用类名调用静态方法
//            //Counter.showInstance(); //不能使用类名调用实例方法
//            Counter c2 = new Counter();
//            c1.showInstance(); c2.showInstance();
//        }
//    }
//}
