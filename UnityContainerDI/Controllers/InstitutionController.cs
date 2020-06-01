using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityContainerDI.Models;
using UnityContainerDI.Services;

namespace UnityContainerDI.Controllers
{
    public class InstitutionController : Controller
    {
        IInstitutionServices _instance;
        public InstitutionController(IInstitutionServices instance)
        {
            _instance = instance;
        }
        // GET: Institution
        public ActionResult GetAllInstitutes()
        {
            List<Institution> institutes = _instance.GetAllInstitutes();

            return View(institutes);
        }
    }
}