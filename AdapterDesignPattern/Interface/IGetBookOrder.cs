using AdapterDesignPattern.POCO;
using System.Collections.Generic;

namespace AdapterDesignPattern.Interface
{
    public interface IGetBookOrder
    {
        List<Order> GetBookOrders();
    }
}
