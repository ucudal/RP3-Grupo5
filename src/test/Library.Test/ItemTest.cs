using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
   //Salta un error al intentar correr los test, no pudimos solucionarlo, 
   //si puede explicarnos en que estamos fallando le agradezco
   //ERROR:
   //El nombre del tipo o del espacio de nombres 'Spell' no se encontró 
   //(¿falta una directiva using o una referencia de ensamblado?

   //Repetir test para cada Item o usar la interface en los tests?

    public class ItemTests
    {
      [Test]
        public void TestItemAttackValue()
        {
           const int expected = 100;
           Staff staff = new Staff();
           Assert.AreEqual(expected, staff.AttackValue);
        }
         
      [Test]
        public void TestItemDefenseValue()
        {
           const int expected = 100;
           Staff staff = new Staff();
           Assert.AreEqual(expected, staff.DefenseValue);
        }

      [Test]
      public void TestAddSpellToBook()
      {  
         const int expected = 140;  
         SpellsBook book = new SpellsBook();
         ISpell spell = new SpellOne();
         book.AddSpell(spell);         
         Assert.AreEqual(expected, (book.AttackValue + book.DefenseValue));
      }
    }
//Testeamos el valor del tipo de item a ver si es correspondiente con el esperado(expected)
}
