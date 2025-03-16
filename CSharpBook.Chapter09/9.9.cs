﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Chapter09
{
    //步骤1：声明提供事件数据的类
    public class NameListEventArgs:EventArgs
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public NameListEventArgs(string name,int count)
        {
            Name = name; Count = count;
        }
    }
    //步骤2：声明事件处理委托
    public delegate void NameListEventHandler(object source, NameListEventArgs args);
    //步骤3：声明引发事件的类（事件产生类）
    public class NameList
    {
        ArrayList list;
        //步骤4：在事件产生类中声明事件
        public event NameListEventHandler nameListEvent;
        public NameList()
        {
            list = new ArrayList();
        }
        public void Add(string Name)
        {
            list.Add(Name);
            //步骤5：在事件生产类中，实现产生事件的代码
            if (nameListEvent != null)
            {
                nameListEvent(this, new NameListEventArgs(Name, list.Count));
            }
        }
    }
    //步骤6：声明处理事件的类（事件消费者）
    public class EventDemo
    {
        //步骤7：在事件消费者中，声明事件处理方法
        public static void Method1(object source, NameListEventArgs args)
        {
            Console.WriteLine("列表中增加了项目：{0}", args.Name);
        }
        public static void Method2(object source, NameListEventArgs args)
        {
            Console.WriteLine("列表中的项目数：{0}", args.Count);
        }
        public static void Main()
        {
            NameList n1 = new NameList();
            //步骤8：在事件消费者中，订阅或取消事件
            n1.nameListEvent += new NameListEventHandler(EventDemo.Method1);
            n1.nameListEvent += new NameListEventHandler(EventDemo.Method2);
            n1.Add("张三"); n1.Add("李四"); n1.Add("王五"); Console.ReadLine();
        }
    }
}
