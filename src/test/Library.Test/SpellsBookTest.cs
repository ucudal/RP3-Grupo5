using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
{
    public class SpellsBookTests
    {
        [Test]
        public void LibroDeHechizosUnHechizoAtack()
        {
            SpellsBook book = new SpellsBook();
            ISpell spell = new SpellOne();
            book.AddSpell(spell);       
            int expected = 70;
            Assert.AreEqual(book.AttackValue, expected);
            
        }

        [Test]
        public void LibroDeHechizosUnHechizoDefense()
        {
            SpellsBook book = new SpellsBook();
            ISpell spell = new SpellOne();
            book.AddSpell(spell);       
            int expected = 70;
            Assert.AreEqual(book.DefenseValue, expected);
            
        }

        [Test]
        public void LibroDeHechizosDosHechizoAtack()
        {
            SpellsBook book = new SpellsBook();
            ISpell spell = new SpellOne();
            book.AddSpell(spell);       
            int expected = 140;
            ISpell spell2 = new SpellOne();
            book.AddSpell(spell2);
            Assert.AreEqual(book.AttackValue, expected);
            
        }
        [Test]
        public void LibroDeHechizosDosHechizoDefense()
        {
            int expected = 140;
            SpellsBook book = new SpellsBook();
            ISpell spell = new SpellOne();
            book.AddSpell(spell);
            ISpell spell2 = new SpellOne();
            book.AddSpell(spell2);       
            Assert.AreEqual(book.DefenseValue, expected);
            
        }
//Testeamos el valor del tipo de item a ver si es correspondiente con el esperado(expected)        
    }
}