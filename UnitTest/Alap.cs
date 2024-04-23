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
    public abstract class Alap
    {
        protected Form1 form;

        [SetUp]
        public void Setup()
        {
            form = new Form1();
        }

    }
}
