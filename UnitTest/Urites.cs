using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ApiSample;

namespace UnitTest
{

    //ha megnyomom az OK gombot, akkor törlődik e a textboxszerkesztből a beirt cucc

    public class Urites : Alap
    {
        [Test]
        public void MezoUrites()
        {
            // Arrange 

            var form = new Form1();
           
            form.textBoxSzerkeszt.Text = "12";


            // Act
            // az OK gomb click eseményének szimulálása

            form.buttonOK_Click(this, EventArgs.Empty);


            // Assert
            Assert.That(form.textBoxSzerkeszt.Text, Is.EqualTo(string.Empty));
        }


    }
}
