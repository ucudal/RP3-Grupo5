using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: MagicCharacter
    {
        public Wizard(string name, int _vp): base(name)
        {
            this.AddItem(new Staff());
        }
    }
}