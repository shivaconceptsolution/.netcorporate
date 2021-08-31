using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    class Cart
    {
        private int cartid;
        private String itemname;
        private int cartprice;
        private int quantity;

        public int _cartprice
        {
            get { return cartprice; }
            set { value = cartprice; }
        }
        public int _quantity
        {
            get { return quantity; }
            set { value = quantity; }
        }

        internal Cart(int cartid, String itemname, int cartprice, int quantity)
        {
            this.cartid = cartid;
            this.itemname = itemname;
            this.cartprice = cartprice;
            this.quantity = quantity;

        }

        override
        public String ToString()
        {
            return "Cart id is " + cartid + "Item name is " + itemname + "Cart price is " + cartprice + " Quantity is " + quantity;

        }
    }
}
