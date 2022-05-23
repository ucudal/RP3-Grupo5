using System.Collections.Generic;
using System;
namespace RoleplayGame
{
    public class DarkDwarf: Enemigo
    {

        public DarkDwarf(string name) : base (name)
        {
            this.Name = name;
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}