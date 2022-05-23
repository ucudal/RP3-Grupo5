using System.Collections.Generic;
namespace RoleplayGame
{
    public class Character
    {
        public string Name { get; set; }

        private int health = 100;

        private int vp;

        public List<IItem> items = new List<IItem>();

        public Character (string name)
        {
            this.Name = name;
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public int VP
        {
            get
            {
                return this.vp;
            }
            set 
            {
                this.vp = value;
            }
        }
        

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

    }
}