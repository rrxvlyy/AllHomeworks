using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInterfaces
{
    internal interface IStackable
    {
        int Count { get; }
        void AddOne();
        void RemoveOne();
    }
}
