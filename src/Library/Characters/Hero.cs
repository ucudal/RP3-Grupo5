namespace RoleplayGame
{
    public abstract class Hero: Character
    {

         private int VP;

        public int vp
        {
            get {return VP;}
            set {VP = 0;}
        }

        public Hero (string name):base(name)
        {
        }

    }
}