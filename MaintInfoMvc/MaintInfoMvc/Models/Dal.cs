using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaintInfoMvc.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;
        public Dal()
        {
            bdd = new BddContext();
        }

        // Client 
        public List<Client> ObtientTousLesClients()
        {
            return bdd.Clients.ToList();
        }
        public bool ClientExiste(string nom)
        {
            return bdd.Clients.Any(client => string.Compare(client.nom_client, nom, 
                StringComparison.CurrentCultureIgnoreCase) == 0);
        }
        public void CreerClient(string nom, string adresse, string cp, string ville, string tel)
        {
            bdd.Clients.Add(new Client
            {
                nom_client = nom,
                adresse_client = adresse,
                cp_client = cp,
                ville_client = ville,
                tel_client = tel
            });
            bdd.SaveChanges();
        }
        public void ModifierClient(int id, string nom, string adresse, string cp, string ville, string tel)
        {
            Client clientTrouve = bdd.Clients.FirstOrDefault(client => client.num_client == id);
            if (clientTrouve != null)
            {
                clientTrouve.nom_client = nom;
                clientTrouve.adresse_client = adresse;
                clientTrouve.cp_client = cp;
                clientTrouve.ville_client = ville;
                clientTrouve.tel_client = tel;
                bdd.SaveChanges();
            }
        }

        // Centre
        public List<CentreInformatique> ObtientTousLesCentresParClient(int idClient)
        {
            List<CentreInformatique> lstci = bdd.Centres.ToList();
            var lstbyid = lstci.Where(p => p.Client.num_client == idClient).ToList();
            return lstbyid;
        }
        public void CreerCentre(string adresse, string cp, string ville, string tel, Client client)
        {
            bdd.Centres.Add(new CentreInformatique { adresse_centre = adresse, cpl_centre = cp, ville_centre = ville,
                tel_centre = tel, Client = client });
            bdd.SaveChanges();
        }
        public void ModifierCentre(int id, string adresse, string cp, string ville, string tel)
        {
            CentreInformatique centreTrouve = bdd.Centres.FirstOrDefault(centre => centre.num_centre == id);
            if (centreTrouve != null)
            {
                centreTrouve.adresse_centre = adresse;
                centreTrouve.cpl_centre = cp;
                centreTrouve.ville_centre = ville;
                centreTrouve.tel_centre = tel;
                bdd.SaveChanges();
            }
        }

        // Contrat
        public Contrat ObtientLeContratParCentre(int idCentre)
        {
            return bdd.Contrats.FirstOrDefault(c => c.Centre.num_centre == idCentre);
        }
        public void CreerContrat(double montant, CentreInformatique centre)
        {
            Contrat contratExiste = bdd.Contrats.FirstOrDefault(contrat => contrat.Centre == centre);
            if (contratExiste == null)
            {
                bdd.Contrats.Add(new Contrat { date_creation_contrat = DateTime.Now,
                    date_echeance_contrat = DateTime.Now.AddYears(1), statut = 1, commentaire_contrat = "En cours",
                    Centre = centre });
            }
        }
        public void ModifierContrat(int id, double montant, short statut)
        {
            Contrat contratTrouve = bdd.Contrats.FirstOrDefault(contrat => contrat.num_contrat == id);
            if (contratTrouve != null)
            {
                switch (statut)
                {
                    case 2:
                        contratTrouve.montant_contrat = montant;
                        contratTrouve.date_echeance_contrat = contratTrouve.date_echeance_contrat.AddYears(1);
                        contratTrouve.statut = statut;
                        contratTrouve.commentaire_contrat = "Renouvellé";
                        break;
                    case 3:
                        contratTrouve.date_resiliation_contrat = contratTrouve.date_echeance_contrat;
                        contratTrouve.statut = statut;
                        contratTrouve.commentaire_contrat = "Resilié";
                        break;
                }
                bdd.SaveChanges();
            }
        }

        // Dispose
        public void Dispose()
        {
            bdd.Dispose();
        }

        

        

        

        

        

       
    }
}