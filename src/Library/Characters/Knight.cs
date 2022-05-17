using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: NoMagicChar
    {
        public Knight(string name, int _vp): base(name)
        {        
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
    }
}