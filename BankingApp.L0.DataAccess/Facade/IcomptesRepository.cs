using BankingApp.L0.Domain;
using System.Collections.Generic;

namespace BankingApp.L1.DataAccess.Facade
{
    public interface IComptesRepository
    {
        //CRUD 

        void OuvrirCompte(Compte cp);       //C
        Compte RecupCompteById(string id);    //R
        IList<Compte> AllCompte();          //R
        void UpdateCompte(Compte cp);       //U
        void DeleteCompte(string id);       //D



    }
}
