using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.data.Entities;
using webapi.data.Repositories;

namespace webapi.business.Services.Impl
{
  public class ApplicantService : IApplicantService
  {
    private readonly IApplicantRepository _repo;
    public ApplicantService(IApplicantRepository repo)
    {
      _repo = repo;
    }
    public List<Applicant> GetList()
    {
      return _repo.GetList();
    }
  }
}