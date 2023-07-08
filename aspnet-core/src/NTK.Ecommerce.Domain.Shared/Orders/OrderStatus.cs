using System;
using System.Collections.Generic;
using System.Text;

namespace NTK.Ecommerce.Orders
{
    public enum OrderStatus
    {
        New,
        Confirmed,
        Processing,
        Shipping,
        Finished,
        Canceled
    }
}
