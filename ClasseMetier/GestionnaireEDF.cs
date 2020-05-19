using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMetier
{
    public class GestionnaireEDF : IEDF
    {
        public List<Controleur> LesControleurs { get; set; }

        public GestionnaireEDF()
        {
            LesControleurs = new List<Controleur>();
        }

        public List<Client> GetAllClientsByControleur(int idControleur)
        {
            List<Client> LesClientsParControleur = new List<Client>();

            foreach(Controleur co in LesControleurs)
            {
                if(idControleur == co.IdControleur)
                {
                    foreach (Client cl in co.LesClients)
                    {

                        LesClientsParControleur.Add(cl);
                    }
                }

            }
            return LesClientsParControleur;
        }

        public List<Controleur> GetAllControleur()
        {
            return LesControleurs;
        }

        public int NumberofClientsByControleur(int idControleur)
        {
            int nbClientsParControleurs = 0;
            foreach(Controleur co in LesControleurs)
            {
                if(idControleur == co.IdControleur)
                {
                    foreach (Client cl in co.LesClients)
                    {
                        nbClientsParControleurs++;
                    }
                }
            }
            return nbClientsParControleurs;
        }

        public int NumberofNewClients()
        {
            int nbNewClients = 0;
            foreach(Controleur co in LesControleurs)
            {
                foreach(Client cl in co.LesClients)
                {
                    if(cl.AncienRelve == 0)
                    {
                        nbNewClients++;
                    }
                }
            }
            return nbNewClients;

        }

        public int NumberTotalofClients()
        {
            int nbTotalClients = 0;
            foreach(Controleur co in LesControleurs)
            {
                nbTotalClients = co.LesClients.Count + nbTotalClients;
            }
            return nbTotalClients;
        }

        public void UpdateCompteur(int idCompteur, int nouveauReleve)
        {
            foreach(Controleur co in LesControleurs)
            {
                foreach(Client cl in co.LesClients)
                {
                    if(cl.IdCompteur == idCompteur)
                    {
                        cl.NouveauReleve = nouveauReleve;
                    }
                }
            }
        }
    }
}
