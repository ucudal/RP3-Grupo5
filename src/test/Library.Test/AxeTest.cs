using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
    {
        public class AxeTest
        {
            [Test]
            public void AtaqueValido()
            {
                IAttackItem hacha = new Axe();
                const int expected = 25;
                Assert.AreEqual(expected, hacha.AttackValue);
            }
//Testeamos el valor del tipo de item a ver si es correspondiente con el esperado(expected)
        }
    }