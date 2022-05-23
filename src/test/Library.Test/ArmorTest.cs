using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ArmorTest
    {
        [Test]
        public void DefensaValida()
        {
            IDefenseItem armadura = new Armor();
            const int expected = 25;
            Assert.AreEqual(expected, armadura.DefenseValue);
        }
    }
}