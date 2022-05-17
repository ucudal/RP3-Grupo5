using System.Collections.Generic;
namespace RoleplayGame
{
    public class MagicCharacter: Hero
    {
        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public MagicCharacter(string name): base(name)
        {
        }

        public int AttackValueForMagicChar
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
                foreach (MagicalItem item in this.magicalItems)
                {
                    if (item is MagicalAttackItem)
                    {
                        value += (item as MagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

         public int DefenseValueForMagicChar
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
                foreach (MagicalItem item in this.magicalItems)
                {
                    if (item is MagicalDefenseItem)
                    {
                        value += (item as MagicalDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public void ReceiveAttackForMagicChar(int power)
        {
            if (this.DefenseValueForMagicChar < power)
            {
                this.Health -= power - this.DefenseValueForMagicChar;
            }
        }

        void AddMagicItem(MagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        void RemoveMagicItem(MagicalItem item)
        {
            this.magicalItems.Remove(item);
        }
    }
}
