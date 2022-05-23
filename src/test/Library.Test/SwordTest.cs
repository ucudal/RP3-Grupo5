using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
    {
        public class SwordTest
        {
            [Test]
            public void AtaqueValido()
            {
                IAttackItem espada = new Sword();
                const int expected = 20;
                Assert.AreEqual(expected, espada.AttackValue);
            }
//Testeamos el valor del tipo de item a ver si es correspondiente con el esperado(expected)
        }
    }