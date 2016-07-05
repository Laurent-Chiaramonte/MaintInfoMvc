using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaintInfoMvc.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<CentreInformatique> Centres { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
    }
}