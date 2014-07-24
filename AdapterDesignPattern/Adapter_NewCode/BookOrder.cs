using AdapterDesignPattern.Adaptee_LegacyCode;
using AdapterDesignPattern.Interface;
using AdapterDesignPattern.POCO;
using System;
using System.Collections;
using System.Collections.Generic;


namespace AdapterDesignPattern.Adapter_NewCode
{
    public class BookOrder : GetXMLBookOrder, IGetBookOrder
    {
        ArrayList BookOrderArray;
        List<Order> BookOrders = new List<Order>();
        
        List<Order> IGetBookOrder.GetBookOrders()
        {
            BookOrderArray = ReadXML();

            foreach (string[] Order in BookOrderArray)
            {
                BookOrders.Add(new Order { Title = Order[0], ISBN = Order[1], Author = Order[2], Price = Convert.ToDouble(Order[3]), Quantity = Convert.ToInt32(Order[4]), Customer = Order[5] });
            }
            return BookOrders;
        }
    }
}
