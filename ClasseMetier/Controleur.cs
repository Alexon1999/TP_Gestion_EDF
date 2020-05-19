using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMetier
{
    public class Controleur
    {
        private static int numero;

        public int IdControleur { get; set; }

        public string PrenomControleur { get; set; }

        public List<Client> LesClients { get; set; }


        public Controleur () { }

        public Controleur(string unPrenom)
        {
            PrenomControleur = unPrenom;
        }
    }
}
