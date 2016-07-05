using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MaintInfoMvc.Models
{
    public class Init : DropCreateDatabaseAlways<BddContext>
    {
        protected override void Seed(BddContext context)
        {
            // Clients
            context.Clients.Add(new Client
            {
                num_client = 1,
                nom_client = "Panzani",
                adresse_client = "34, avenue de corot",
                cp_client = "13013",
                ville_client = "Marseille",
                tel_client = "0491609023"
            });
            context.Clients.Add(new Client
            {
                num_client = 2,
                nom_client = "Heineken",
                adresse_client = "14, rue François Chardigny",
                cp_client = "13011",
                ville_client = "Marseille",
                tel_client = "0491691322"
            });

            // Centres
            context.Centres.Add(new CentreInformatique
            {
                num_centre = 1,
                adresse_centre = "34, avenue de corot",
                cpl_centre = "13013",
                ville_centre = "Marseille",
                tel_centre = "0491609023",
                Client = new Client() { num_client = 1}
            });
            context.Centres.Add(new CentreInformatique
            {
                num_centre = 2,
                adresse_centre = "11, chemin du littoral",
                cpl_centre = "13015",
                ville_centre = "Marseille",
                tel_centre = "0491601462",
                Client = new Client() { num_client = 1 }
            });
            context.Centres.Add(new CentreInformatique
            {
                num_centre = 3,
                adresse_centre = "14, rue François Chardigny",
                cpl_centre = "13011",
                ville_centre = "Marseille",
                tel_centre = "0491691322",
                Client = new Client() { num_client = 2 }
            });

            // Contrats
            context.Contrats.Add(new Contrat
            {
                num_contrat = 1,
                montant_contrat = 24.65,
                date_creation_contrat = new DateTime(2011, 02, 12),
                date_echeance_contrat = new DateTime(2012, 02, 12),
                statut = 1,
                commentaire_contrat = "En cours",
                Centre = new CentreInformatique() { num_centre = 1 }
            });
            context.Contrats.Add(new Contrat
            {
                num_contrat = 2,
                montant_contrat = 13.480,
                date_creation_contrat = new DateTime(2011, 03, 13),
                date_echeance_contrat = new DateTime(2012, 03, 13),
                statut = 1,
                commentaire_contrat = "En cours",
                Centre = new CentreInformatique() { num_centre = 2 }
            });
            context.Contrats.Add(new Contrat
            {
                num_contrat = 3,
                montant_contrat = 32.740,
                date_creation_contrat = new DateTime(2016, 04, 15),
                date_echeance_contrat = new DateTime(2017, 04, 15),
                statut = 1,
                commentaire_contrat = "En cours",
                Centre = new CentreInformatique() { num_centre = 3 }
            });

            base.Seed(context);
        }
    }
}