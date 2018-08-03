using ComptesApp.Library.Facade;
using ODDO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesApp.Library.Implementation
{
    public class CompteManager_Memory : IcompteManager
    {

        private IList<Compte> data = new List<Compte> {

            new Compte {Numero = "C1000" , Proprietaire="Zak" , Solde=1000M},
            new Compte {Numero = "C1001" , Proprietaire="ahmed" , Solde=2000M}
        };


        public IList<Compte> AllCompte()
        {
            throw new NotImplementedException();
        }

        public void DeleteCompte(string id)
        {
            throw new NotImplementedException();
        }

        public void OuvrirCompte(Compte cp)
        {
            throw new NotImplementedException();
        }

        public void RecupCompteById(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCompte(Compte cp)
        {
            throw new NotImplementedException();
        }
    }
}
