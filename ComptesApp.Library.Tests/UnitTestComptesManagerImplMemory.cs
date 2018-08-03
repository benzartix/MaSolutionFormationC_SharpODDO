using System;
using System.Collections.Generic;
using System.Linq;
using ComptesApp.Library.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ODDO.Domain;

namespace ComptesApp.Library.Tests
{
    [TestClass]
    public class UnitTestComptesManagerImplMemory
    {
        [TestMethod]
        public void TestFindAll()
        {

            //Arrange

            var underTest = new CompteManager_Memory();
            var expected = 2; // nb of acount

            //ACT

            var actual = underTest.AllCompte();

            //Assert
            Assert.AreEqual(expected, (IList<Compte>)actual.Count);



        }
    }
}
