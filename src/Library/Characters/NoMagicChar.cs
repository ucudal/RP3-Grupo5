using System.Collections.Generic;
namespace RoleplayGame
{
    public class NoMagicChar: Hero
    {
        public NoMagicChar(string name):base(name)
        { 
        }

        public int AttackValue
        {
            get 
            {
                int value = 0;
                foreach (Item item in this.items)
                {
                    if (item is AttackItem)
                    {
                        value += (item as AttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public  int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Item item in this.items)
                {
                    if (item is DefenseItem)
                    {
                        value += (item as DefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }
    }
}