//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpBook.Chapter07
//{
//    class TempRecord
//    {
//        private float[] temps = new float[5] { 20.1F, 20.2F, 21.5F, 26.9F, 16.8F };
//        public int Length
//        {
//            get { return temps.Length; }
//        }
//        public float this[int index]
//        {
//            get { return temps[index]; }
//            set { temps[index] = value; }
//        }
//    }

//    class MainClass
//    {
//        static void Main()
//        {
//            TempRecord tempRecord = new TempRecord();
//            tempRecord[3] = 26.3F; tempRecord[4] = 62.1F;
//            for(int i = 0; i<tempRecord.Length; i++)
//            {
//                Console.WriteLine("Element #{0} = {1}", i, tempRecord[i]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
