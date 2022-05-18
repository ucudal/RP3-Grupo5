using System.Collections.Generic;
namespace RoleplayGame
{
    public class BlackArcher: Enemigo
    {

        public BlackArcher(string name, int vptogive):base(name, vptogive)
        {
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}