using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces
{
    internal interface ISellable
    {
        int Price { get; }
        void Sell(Character user);
    }
}
