using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ApiSample;

namespace UnitTest
{
    public class Szures_teszt
    {
        // ellenőrizni, hogy a szűrő textbox valóban szűri e a listboxot
   

        [TestFixture]
        public class TextBoxSzuroTest
        {
            [Test]
            public void TextBoxSzuro_szures()
            {
                // Arrange
                var form = new Form1();

                var bicikli1 = new Bicok { nev = "Gepida123", id = 1 };
                var bicikli2 = new Bicok { nev = "Trek", id = 2 };
                var bicikli3 = new Bicok { nev = "Cannondale", id = 3 };
                var bicikli4 = new Bicok { nev = "8xTxGepida123456", id = 4 };

                form.termeklista.Add(bicikli1);
                form.termeklista.Add(bicikli2);
                form.termeklista.Add(bicikli3);
                form.termeklista.Add(bicikli4);

                // Act
                form.textBoxSzuro.Text = "Gep"; // Szűrőfeltétel beállítása
                form.BicoSzures(); // Szűrés végrehajtása

              
                var szurtLista = form.listBoxRaktar.DataSource as List<Bicok>;

            

                // Assert
                // Ellenőrizzük, hogy a szűrt lista tartalmazza-e az elvárt bicikliket



                Assert.That(szurtLista, Has.Member(bicikli1));
                Assert.That(szurtLista, Has.No.Member(bicikli2));// "Trek" ne szerepeljen a szűrt listában
                Assert.That(szurtLista, Has.No.Member(bicikli3));// "Cannondale" ne szerepeljen a szűrt listában
                Assert.That(szurtLista, Has.Member(bicikli4));

            }

            
        }
    }
}
