using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.data.Entities;

namespace webapi.data.Repositories
{
  public interface IApplicantRepository
  {
    List<Applicant> GetList();
  }
}