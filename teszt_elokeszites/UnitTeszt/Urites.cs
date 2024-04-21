using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using teszt_elokeszites;

namespace UnitTeszt
{
    [TestFixture]
    public class Urites
    {
       
    

        [Test]
        public void Mezok_uritese()
        {
            // Arrange
            var form = new Form1();
            
            // valamilyen értékeket beírunk a textboxokba, ezeket próbálja az Ürítő gomb kitörölni majd
            form.textBoxMegnevezes.Text = "Mountain Bike";
            form.textBoxCikkszam.Text = "C001";
            form.textBoxMennyiseg.Text = "10";
            form.textBoxEgysegar.Text = "1000000";

            // Act
            // az Üritő gomb click eseményének szimulálása
            form.buttonUrites_Click(this, EventArgs.Empty);

            // Assert
            Assert.That(form.textBoxMegnevezes.Text, Is.EqualTo(string.Empty));
            Assert.That(form.textBoxCikkszam.Text, Is.EqualTo(string.Empty));
            Assert.That(form.textBoxMennyiseg.Text, Is.EqualTo(string.Empty));
            Assert.That(form.textBoxEgysegar.Text, Is.EqualTo(string.Empty));
            
            //Még egy féle módszer az ellenőrzésre:

            //Assert.That("", Is.EqualTo(form.textBoxMegnevezes.Text));
            //Assert.That("", Is.EqualTo(form.textBoxCikkszam.Text));
            //Assert.That("", Is.EqualTo(form.textBoxMennyiseg.Text));
            //Assert.That("", Is.EqualTo(form.textBoxEgysegar.Text));


        }
    }
}
