using System.Collections.Generic;
using System;
namespace RoleplayGame
{
    public class Enemigo: Character
    {

        public Enemigo (string name) : base (name)
        {
            this.VP = 5;
        }
    }
}