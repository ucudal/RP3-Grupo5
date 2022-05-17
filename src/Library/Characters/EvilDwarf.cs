using System.Collections.Generic;
namespace RoleplayGame
{
    public class EvilDwarf: Enemigo
    {
        public EvilDwarf(string name, int vptogive):base(name, vptogive)
        { 
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}