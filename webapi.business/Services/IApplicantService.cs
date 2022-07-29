using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.data.Entities;

namespace webapi.business.Services
{
  public interface IApplicantService
  {
    List<Applicant> GetList();
  }
}