using BankingApp.L0.DataAccess.Infrastructure;
using BankingApp.L0.Domain;
using BankingApp.L1.DataAccess.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L0.DataAccess.Implementations
{
    public class ComptesRepositoryImpl_EF : IComptesRepository
    {
        //Stub: obliger l'implementation 
        //Moq : on ne fait pas d'implementation : utilisé  pour les teste pour isolé les dependance

        public IList<Compte> AllCompte()
        {
            using (var ctxt = new BankContext())
            {
                return ctxt.comptes.ToList();
            }
        }

        public void DeleteCompte(string id)
        {
            throw new NotImplementedException();
        }

        public void OuvrirCompte(Compte cp)
        {
            using (var ctxt = new BankContext())
            {
                ctxt.comptes.Add(cp);
                ctxt.SaveChanges();
            }
        }

        public Compte RecupCompteById(string id)
        {
            using (var ctxt = new BankContext())
            {
                return ctxt.comptes.FirstOrDefault(c => c.Numero.Equals(id));
            }
        }

        public void UpdateCompte(Compte cp)
        {
            throw new NotImplementedException();
        }

    }
}
