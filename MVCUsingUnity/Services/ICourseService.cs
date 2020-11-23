using MVCUsingUnity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCUsingUnity.Services
{
    interface ICourseService
    {
        Course GetCourseByID(long courseID);
    }
}
