using MVCUsingUnity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCUsingUnity.Services
{
    public interface IInstitutionService
    {
        Institution GetInstitutionByID(long institutionID);
    }
}