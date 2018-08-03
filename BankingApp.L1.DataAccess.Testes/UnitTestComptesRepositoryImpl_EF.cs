using System;
using BankingApp.L0.DataAccess.Implementations;
using BankingApp.L0.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.L1.DataAccess.Testes
{
    [TestClass]
    public class UnitTestComptesRepositoryImpl_EF
    {
        [TestMethod]
        public void TestOuvrirCompte()
        {

            //ARRANGE
            var c = new Compte { Numero = "C100", Proprietaire = "Med Amine", Solde = 100M };
            var underTest = new ComptesRepositoryImpl_EF();


            //ACT
            underTest.OuvrirCompte(c);

            //ASSERT
            // Act ne retourne rien si c'est bon 

            //}


            //[TestMethod]
            //public void TestFindById()
            //{

            //    //ARRANGE
            //    var id = "C100";
            //    var expected = new Compte { Numero = "C100", Proprietaire = "Med Amine", Solde = 100M };

            //    var underTest = new ComptesRepositoryImpl_EF();


            //    //ACT

            //     var actual = underTest.RecupCompteById(id);

            //    //ASSERT
            //    Assert.AreEqual(expected,actual);

            //}
        }
    }
