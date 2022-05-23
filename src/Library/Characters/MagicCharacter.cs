using System.Collections.Generic;
using System;
namespace RoleplayGame
{
    public class MagicCharacter: Character, IHeroe
    {
        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public MagicCharacter (string name) : base (name)
        {
            this.VP = 0;
        }

        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += (item as IMagicalDefenseItem).DefenseValue;
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

        public void AddMagicItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveMagicItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }
    }
}