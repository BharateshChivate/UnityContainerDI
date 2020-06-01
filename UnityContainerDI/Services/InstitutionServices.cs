using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnityContainerDI.Models;

namespace UnityContainerDI.Services
{
    public class InstitutionServices : IInstitutionServices
    {
        public List<Institution> GetAllInstitutes()
        {
            List<Institution> institutes = new List<Institution>()
            {
                { new Institution() { Id = 1, Name = "GMIt" } },
                { new Institution() { Id = 2, Name = "BIET" } }
            };

            return institutes;
        }
    }
}