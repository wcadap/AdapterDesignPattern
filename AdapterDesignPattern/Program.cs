using System;
using System.Collections.Generic;
using AdapterDesignPattern.Interface;
using AdapterDesignPattern.Adapter_NewCode;
using AdapterDesignPattern.POCO;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IGetBookOrder GetBookOrder = new BookOrder();
            List<Order> _BookOrder = GetBookOrder.GetBookOrders();

            foreach (Order _Order in _BookOrder)
            {
                Console.WriteLine(String.Format("Title    :{0}", _Order.Title));
                Console.WriteLine(String.Format("ISBN     :{0}", _Order.ISBN));
                Console.WriteLine(String.Format("Author   :{0}", _Order.Author));
                Console.WriteLine(String.Format("Price    :{0}", _Order.Price));
                Console.WriteLine(String.Format("Quantity :{0}", _Order.Quantity));
                Console.WriteLine(String.Format("Customer :{0}", _Order.Customer));
                Console.WriteLine("");
            }
        }
    }
}
