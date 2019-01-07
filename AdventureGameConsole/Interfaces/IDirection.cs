using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameConsole.Interfaces
{
    interface IDirection
    {
        void North();
        void South();
        void East();
        void West();
        void Up();
        void Down();
        void Under();
        void Over();
        void Hidden();
        void Special();
    }
}
