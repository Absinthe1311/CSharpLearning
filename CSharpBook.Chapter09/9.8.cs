﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpBook.Chapter09
//{
//    public delegate void SampleEventHandler(object sender, EventArgs e);
//    public class Publisher
//    {
//        public event SampleEventHandler SampleEvent;
//        protected virtual void RaiseSampleEvent()//产生事件
//        {
//            SampleEvent(this, new EventArgs()); //引发事件
//        }
//    }
//    public class Subscriber
//    {
//        public static void Method1(object sender, EventArgs e)
//        {
//            Console.WriteLine("To Do Something...");
//        }
//        public static void Method2(object sender, EventArgs e)
//        {
//            Console.WriteLine("To Do Something...");
//        }
//        public static void Main()
//        {
//            SampleEventHandler d1 = new SampleEventHandler(Subscriber.Method1);
//            Publisher p = new Publisher();
//            p.SampleEvent += d1;
//            p.SampleEvent += new SampleEventHandler(Subscriber.Method2); //订阅事件
//            p.SampleEvent -= d1;
//        }
//    }
//}
