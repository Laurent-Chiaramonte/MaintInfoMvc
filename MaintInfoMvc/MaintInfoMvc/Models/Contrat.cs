using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaintInfoMvc.Models
{
    public class Contrat
    {
        #region Propriétés
        public virtual int num_contrat
        {
            get;
            set;
        }

        public virtual double montant_contrat
        {
            get;
            set;
        }

        public virtual DateTime date_creation_contrat
        {
            get;
            set;
        }

        public virtual DateTime date_echeance_contrat
        {
            get;
            set;
        }

        public virtual DateTime date_resiliation_contrat
        {
            get;
            set;
        }

        public virtual string commentaire_contrat
        {
            get;
            set;
        }

        public virtual short statut
        {
            get;
            set;
        }

        public virtual CentreInformatique Centre
        {
            get;
            set;
        }
        

        #endregion
    }
}