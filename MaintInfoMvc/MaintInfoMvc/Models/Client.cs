using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaintInfoMvc.Models
{
    public class Client
    {
        #region Proprietes
        public virtual int num_client
        {
            get;
            set;
        }

        public virtual string nom_client
        {
            get;
            set;
        }

        public virtual string adresse_client
        {
            get;
            set;
        }

        public virtual string cp_client
        {
            get;
            set;
        }

        public virtual string ville_client
        {
            get;
            set;
        }

        public virtual string tel_client
        {
            get;
            set;
        }
        

        #endregion
    }
}