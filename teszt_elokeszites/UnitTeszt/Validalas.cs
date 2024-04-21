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
    public class Validalas
    {
        private RaktarKeszlet raktarKeszlet;

        [SetUp]
        public void Setup()
        {
            raktarKeszlet = new RaktarKeszlet();
        }

        [Test]
        public void UjTetel_helyesadatok()
        {
            // Arrange
            string megnevezes = "Teszt tétel";
            string cikkszam = "C001";
            int mennyiseg = 10;
            decimal egysegar = 100;

            // Act
            raktarKeszlet.UjTetelHozzaadasa(megnevezes, cikkszam, mennyiseg, egysegar);

            // Assert

            Assert.That(1, Is.EqualTo(raktarKeszlet.RaktarLekerdezes().Count())); // Ellenőrizzük, hogy a tétel hozzáadásra került-e

        }

        //[Test]
        //public void UjTetel_hibasadatok()
        //{
        //    // Arrange
        //    string megnevezes = ""; // hibás megnevezés
        //    string cikkszam = "C001";
        //    int mennyiseg = 10;
        //    decimal egysegar = 100;

        //    // Act
        //    raktarKeszlet.UjTetelHozzaadasa(megnevezes, cikkszam, mennyiseg, egysegar);

        //    // Assert

        //    Assert.That(0, Is.EqualTo(raktarKeszlet.RaktarLekerdezes().Count())); // Ellenőrizzük, hogy a tétel nem került-e hozzáadásra

        //}

    }
}
