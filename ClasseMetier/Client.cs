using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMetier
{
    public class Client:IComparable<Client>
    {
        public int AncienRelve { get; set; }

        public int IdCompteur { get; set; }

        public string NomClient { get; set; }

        public int NouveauReleve { get; set; }

        public Client() { }

        public Client (int unIdCompt , string unNom , int unAncien , int unNouveau)
        {
            IdCompteur = unIdCompt;
            NomClient = unNom;
            AncienRelve = unAncien;
            NouveauReleve = unNouveau;
        }

        public int CompareTo(Client other)
        {
            return 1;
        }

        

    }
}
