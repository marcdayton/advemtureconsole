using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameConsole.Interfaces
{
    interface ITraits
    {
        string Name();
        string Class();
        Array Skills();
        string Size();
        int Health();
        int Strength();
        int Knowledge();
        int AttackSpeed();
        int FootSpeed();
        int Damage();

    }
}
