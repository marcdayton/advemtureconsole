using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGameConsole.Interfaces
{
    interface IActions
    {
        void Move();
        void Attack();
        void Kill();
        void Look();
        void Talk();
        void Get();
        void Drop();
        void Climb();
        void Run();
        void Inventory();
        void Use();
        void Equip();
    }
}
