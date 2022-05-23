using NUnit.Framework;
using System;
using RoleplayGame;

namespace RolePlayTests
    {
        public class ShieldTest
        {
            [Test]
            public void DefensaValida()
            {
                IDefenseItem escudo = new Shield();
                const int expected = 14;
                Assert.AreEqual(expected, escudo.DefenseValue);
            }
//Testeamos el valor del tipo de item a ver si es correspondiente con el esperado(expected)
        }
    }