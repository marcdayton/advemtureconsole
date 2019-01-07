using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameConsole.Interfaces
{
    interface ICreatures : ITraits
    {
        string Alignment();
        string Mood();
    }
}
