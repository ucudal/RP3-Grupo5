using System.Collections.Generic;
using System;
namespace RoleplayGame
{
    public class DarkArcher: Enemigo
    {

        public DarkArcher(string name) : base (name)
        {
            this.Name = name;
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}