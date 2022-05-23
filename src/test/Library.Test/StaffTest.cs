using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
    {
        public class StaffTest
        {
            [Test]
            public void DefensaValida()
            {
                IDefenseItem stafo = new Staff();
                const int expected = 100;
                Assert.AreEqual(expected, stafo.DefenseValue);
            }

            public void AtaqueValido()
            {
                IAttackItem stafo = new Staff();
                const int expected = 100;
                Assert.AreEqual(expected, stafo.AttackValue);
            }
        }
//Testeamos el valor del tipo de item a ver si es correspondiente con el esperado(expected)
    }