using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameConsole.Interfaces
{
    interface ICharacter: ITraits
    {
        string Alignment();
        string Mood();
    }
}
