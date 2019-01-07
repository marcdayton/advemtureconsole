using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameConsole.Interfaces
{
    interface ILocation
    {
        string Name();
        String Description();
        int ID();
        Array Location();
        //[CurrentRoomID, N, S, E, W, Up, Down, Over, Under, Hidden, Special]  IDs rooms you can travel to. if ID starts with * direction is not accessible
    }
}
