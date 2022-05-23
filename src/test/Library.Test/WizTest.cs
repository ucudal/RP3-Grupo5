using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
   //REPETIR ESTO PARA CADA PERSONAJE

    public class WizTests
    {
      [Test]
        public void TestName()
        {
           const string expected = "Gandalf";
           Wizard gandalf = new Wizard(expected);
           Assert.AreEqual(expected, gandalf.Name);
        }
         
      [Test]
        public void TestIfNameIsEmpty()
        {
           const string expected = " ";
           Wizard gandalf = new Wizard(" ");
           Assert.AreEqual(expected, gandalf.Name);
        }

      [Test]
      public void TestAttackValue()
      {  
         const int expected = 170;  
         SpellsBook book = new SpellsBook();
         ISpell spell = new SpellOne();
         book.AddSpell(spell);
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.AddMagicItem(book);
         Assert.AreEqual(expected, gandalf.AttackValue);
      }

      [Test]
      public void TestDefenseValue()
      {  
         const int expected = 170;  
         SpellsBook book = new SpellsBook();
         ISpell spell = new SpellOne();
         book.AddSpell(spell);
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.AddMagicItem(book);
         Assert.AreEqual(expected, gandalf.DefenseValue);
      }

      [Test]
      public void TestAddStaff()
      {  
         const int expected = 100;   
         Wizard gandalf = new Wizard("Gandalf");
         Assert.AreEqual(expected, gandalf.AttackValue);
      }

      [Test]
      public void TestAddBookAndSpell()
      {  
         const int expected = 70;  
         SpellsBook book = new SpellsBook();
         ISpell spell = new SpellOne();
         book.AddSpell(spell);
         Assert.AreEqual(expected, book.AttackValue);
      }

       [Test]
        public void TestReciveAttack()
        {
         const int expected = 80;
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.ReceiveAttack(120);
         Assert.AreEqual(expected, gandalf.Health);
        }

       [Test]
        public void TestCure()
        {
         const int expected = 100;
         Wizard gandalf = new Wizard("Gandalf");
         gandalf.ReceiveAttack(50);
         gandalf.Cure();
         Assert.AreEqual(expected, gandalf.Health);
        }
    }
}