using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameConsole.Interfaces
{
    interface IMovement
    {
        void Crawl();
        void Climb();
        void Jump();
        void Sit();
        void Walk();
        void Run();
        void Location();

    }
}
