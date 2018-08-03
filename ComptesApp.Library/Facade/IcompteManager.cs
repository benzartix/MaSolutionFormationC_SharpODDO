using ODDO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesApp.Library.Facade
{
    public interface IcompteManager
    {
        //CRUD 

        void OuvrirCompte(Compte cp);       //C
        void RecupCompteById(string id);    //R
        IList<Compte> AllCompte();    //R
        void UpdateCompte(Compte cp);       //U
        void DeleteCompte(string id);       //D



    }
}
