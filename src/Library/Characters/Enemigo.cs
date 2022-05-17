namespace RoleplayGame
{
    public class Enemigo: Character
    {   
        private int VpToGive;

        public int vpToGive
        {
            get {return VpToGive;}
            set {VpToGive = value;}
        }

        public Enemigo (string name, int _vpToGive):base(name)
        {
            this.vpToGive = _vpToGive;
        }

    }
}