using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCUsingUnity.Models;

namespace MVCUsingUnity.Services
{
    public class InstitutionService : IInstitutionService
    {
        public Institution GetInstitutionByID(long institutionID)
        {
            return new Institution
            {
                InstitutionID = institutionID,
                Name = "Demo Institution",
                Address = "Demo Address",
                Telephone = "0123456789"
            };
        }
    }
}