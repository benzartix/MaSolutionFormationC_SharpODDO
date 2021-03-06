﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L0.Domain
{
    public class Compte
    {
        [Key]
        public string Numero { get; set; } // auto-implemented properties
        public string Proprietaire { get; set; }
        public decimal Solde { get; set; }


        public void Debiter(decimal montant)
        {
            Solde -= montant;
        }

        public void Cediter(decimal montant)
        {
            Solde += montant;
        }


        public override string ToString()
        {
            return "Compte : [ " + Numero + " - " + Proprietaire + " - " + Solde + " ] ";
        }
    }
}
