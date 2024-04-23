using ApiSample;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Check_int
    {
        //leellenőrizni hogy a textboxszerkesztbe int került e

        [TestFixture]
        public class TextBoxSzerkesztSzamEllenorzesTest
        {
            [TestCase("123")] // Szám esetén
            [TestCase("0")]   // 0 esetén
            //[TestCase("-456")] // Negatív szám esetén
            public void SzamEllenorzes_sikeres(string input)
            {
                // Arrange
                var form = new Form1();
                form.textBoxSzerkeszt.Text = input;

                // Act
                bool isNumber = form.CheckSzam(form.textBoxSzerkeszt.Text);

                // Assert

                Assert.That(isNumber, Is.True);
            }



            [TestCase("abc")] // Nem szám esetén
            [TestCase("12a")] // Betű és szám keverékének esetén
            [TestCase("")]    // Üres string esetén
            [TestCase(null)]  // Null érték esetén
            public void SzamEllenorzes_Sikertelen(string input)
            {
                // Arrange
                var form = new Form1();
                form.textBoxSzerkeszt.Text = input;

                // Act
                bool isNumber = form.CheckSzam(form.textBoxSzerkeszt.Text);

                // Assert
                Assert.That(isNumber, Is.False);
            }
        }
    }
}
