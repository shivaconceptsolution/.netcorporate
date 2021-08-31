using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    class ObjectArrExample
    {
        object[] arr;
        void AcceptObject(object [] arr)
        {
            this.arr = arr;
        }
        void DisplayObject()
        {
             foreach(object o in arr)
             {
                 Console.WriteLine(o);
             }
        }

        public static void Main()
        {
            ObjectArrExample obj = new ObjectArrExample();
             object [] a = {1001,"XYZ","CS",45000.345};
             obj.AcceptObject(a);
             obj.DisplayObject();
             Console.ReadKey();
        }
    }
}
