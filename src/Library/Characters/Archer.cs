using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: NoMagicChar
    {

        public Archer(string name, int vp):base(name)
        {
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}