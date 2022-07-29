using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.data.Data;
using webapi.data.Entities;

namespace webapi.data.Repositories.Impl
{
  public class ApplicantRepository : IApplicantRepository
  {
    private readonly DataContext _context;

    public ApplicantRepository(DataContext context)
    {
      _context = context;
    }
    public List<Applicant> GetList()
    {
      return _context.Applicant.ToList();
    }
  }
}