using System;
using System.Collections.Generic;
using System.Text;

namespace NTK.Ecommerce.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
