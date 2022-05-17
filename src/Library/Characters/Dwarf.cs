using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: NoMagicChar
    {
        public Dwarf(string name, int vp):base(name)
        { 
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}