using System.Collections.Generic;
using System;
namespace RoleplayGame
{
    public class Orco: Enemigo
    {
        public Orco (string name) : base (name)
        {
            this.Name = name;
            this.AddItem(new Axe());
            this.AddItem(new Sword());
        }
    }
}