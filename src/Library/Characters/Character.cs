using System.Collections.Generic;
using System;
namespace RoleplayGame
{
    public class Character
    {
        private int health = 100;
        public string Name { get; set; }

        private List<Item> items = new List<Item>();

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
            //private set
            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            this.items.Remove(item);
        }
    }
}