using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameConsole.Interfaces
{
    interface IObjects : ITraits
    {
        int Durability();
        int Capacity();
        int Value();
        bool Equipped();
    }
}
