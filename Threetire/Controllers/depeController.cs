using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLogic;
using BussinessObject;

namespace Threetire.Controllers
{
    public class depeController : Controller
    {
        // GET: depe
        private readonly IUserbl _userbl;
        public depeController(IUserbl userbl)
        {
            _userbl=userbl;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Ubussinessobject ubussinessobject)
        {
            //Userbl userbl = new Userbl();
            Ucustom ucustom = _userbl.useradd(ubussinessobject); 
            return View();
        }
    }
}