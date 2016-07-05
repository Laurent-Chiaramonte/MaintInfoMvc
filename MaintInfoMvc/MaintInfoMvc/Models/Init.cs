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
                 //Client = 1
            });

            // Contrats
        }
    }
}