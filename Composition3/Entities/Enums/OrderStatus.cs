using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition3.Entities.Enums
{
    internal enum OrderStatus: int
    {
        PeddingPayment,
        Processing,
        Shipped,
        Delivered,
    }
}
