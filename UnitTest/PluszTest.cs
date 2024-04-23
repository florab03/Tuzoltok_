using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ApiSample;

namespace UnitTest
{
    [TestFixture]
    public class PluszTest
    {
        //hogy ha a plusz gombra nyomok, akkor növekszik e a textboxszerkesztben a szám
        [Test]
        public void ButtonPlusz_Noveles()
        {
            // Arrange
            var form = new Form1();

            var initialValue = 0; // Kezdeti érték beállítása

            form.textBoxSzerkeszt.Text = initialValue.ToString(); // Kezdeti érték beállítása a szövegmezőben

            // Act
            form.buttonPlusz_Click(this, EventArgs.Empty); // ButtonPlusz gombra kattintás szimulálása

            // Assert
            var expectedValue = initialValue + 1; // Az elvárt érték a kezdeti érték növelése eggyel
            var actualValue = int.Parse(form.textBoxSzerkeszt.Text); // Az aktuális érték a szövegmezőből kiolvasva
            Assert.That(actualValue, Is.EqualTo(expectedValue)); // Ellenőrzés, hogy az érték nőtt-e a várakozásoknak megfelelően
        }
    }
}

