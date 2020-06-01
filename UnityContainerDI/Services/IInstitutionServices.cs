using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainerDI.Models;

namespace UnityContainerDI.Services
{
    public interface IInstitutionServices
    {
        List<Institution> GetAllInstitutes();
    }
}
