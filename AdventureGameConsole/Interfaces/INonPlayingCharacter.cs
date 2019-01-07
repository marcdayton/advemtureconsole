using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameConsole.Interfaces
{
    interface INonPlayingCharacter : ITraits
    {
        string Alignment();
        string Mood();
    }
}
