using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaintInfoMvc.Models
{
    public class CentreInformatique
    {
        #region Proprietes
        public virtual int num_centre
        {
            get;
            set;
        }

        public virtual string adresse_centre
        {
            get;
            set;
        }

        public virtual string cpl_centre
        {
            get;
            set;
        }

        public virtual string ville_centre
        {
            get;
            set;
        }

        public virtual string tel_centre
        {
            get;
            set;
        }

        public virtual Client Client
        {
            get;
            set;
        }

        #endregion
    }
}