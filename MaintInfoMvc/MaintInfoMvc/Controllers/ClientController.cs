using MaintInfoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaintInfoMvc.Controllers
{
    public class ClientController : Controller
    {
        private IDal dal;
        
        public ClientController() : this(new Dal()) { }

        public ClientController(IDal dalIoc)
        {
            this.dal = dalIoc;
        }

        public ActionResult Index()
        {
            List<Client> listeDesClients = dal.ObtientTousLesClients();
            return View(listeDesClients);
        }
    }
}