using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoMvc.Models
{
    public interface IDal : IDisposable
    {
        // Client
        void CreerClient(string nom, string adresse, string cp, string ville, string tel);
        void ModifierClient(int id, string nom, string adresse, string cp, string ville, string tel);
        List<Client> ObtientTousLesClients();
        bool ClientExiste(string nom);

        // Centre
        void CreerCentre(string adresse, string cp, string ville, string tel, Client client);
        void ModifierCentre(int id, string adresse, string cp, string ville, string tel);
        List<CentreInformatique> ObtientTousLesCentresParClient(int idClient);

        // Contrat
        void CreerContrat(double montant, CentreInformatique centre);
        void ModifierContrat(int id, double montant, short statut);
        Contrat ObtientLeContratParCentre(int idCentre);
    }
}
