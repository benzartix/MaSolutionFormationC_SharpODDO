using BankingApp.L0.DataAccess.Implementations;
using BankingApp.L1.DataAccess.Facade;
using BankingApp.L2.Business.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L2.Business.Implementation
{
    public class CompteBusinessImpl : ICompteBusiness
    {
        public const decimal TAUX = 0.1M; 
        private IComptesRepository repo = new ComptesRepositoryImpl_EF(); 

        public decimal ConsulterSolde(string id)
        {
            var rst = repo.RecupCompteById(id);
            if (rst != null)
            {
                return (rst.Numero.StartsWith("E")) ? rst.Solde * (1 + TAUX) : rst.Solde; 
            }
            else
            {
                return decimal.MinValue;
            }

        }
    }
}
