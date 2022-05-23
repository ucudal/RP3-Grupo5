using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
    {
        public class BowTest
        {
            [Test]
            public void AtaqueValido()
            {
                IAttackItem arco = new Bow();
                const int expected = 15;
                Assert.AreEqual(expected, arco.AttackValue);
            }
//Testeamos el valor del tipo de item a ver si es correspondiente con el esperado(expected)
        }
    }