using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMetier
{
    interface IEDF
    {
        List<Client> GetAllClientsByControleur(int idControleur);

        List<Controleur> GetAllControleur();

        int NumberofClientsByControleur(int idControleur);

        int NumberofNewClients();

        int NumberTotalofClients();

        void UpdateCompteur(int idCompteur, int nouveauReleve);
    }
}
