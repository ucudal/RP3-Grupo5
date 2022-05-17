namespace RoleplayGame
{
    public class Orco: Enemigo
    {
        public Orco(string name, int vptogive): base(name, vptogive)
        {        
            this.AddItem(new Sword());
            this.AddItem(new Axe());
            this.AddItem(new Armor());

        }
    }
}