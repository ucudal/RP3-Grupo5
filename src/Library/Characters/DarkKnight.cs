namespace RoleplayGame
{
    public class DarkKnight: Enemigo
    {
        public DarkKnight(string name, int vptogive): base(name, vptogive)
        {        
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
    }
}