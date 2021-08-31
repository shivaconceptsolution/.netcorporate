using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    class Customer
    {
        static void Main()
        {
            //Cart c = new Cart(1, "", 1, 1);


            int size=2;
            String iname;
            int price, qt;
            int total = 0;
            Cart [] arr = new Cart[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Item name");
                iname = Console.ReadLine();
                Console.WriteLine("Enter Item Price");
                price = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter quanity");
                qt = Convert.ToInt16(Console.ReadLine());
                arr[i] = new Cart(i+1,iname,price,qt);
                
            }

            foreach(Cart c in arr)
            {
                total += c._cartprice * c._quantity;
                Console.WriteLine(c);
            }
            Console.WriteLine("Total Cart Price are " + total);
            Console.ReadKey();
        }
    }
}
