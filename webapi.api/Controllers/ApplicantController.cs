using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.business.Services;
using webapi.data.Entities;

namespace webapi.api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ApplicantController : ControllerBase
  {
    private readonly IApplicantService _service;
    public ApplicantController(IApplicantService service)
    {
      _service = service;
    }

    [HttpGet]
    public ActionResult GetList()
    {
      List<Applicant> listApplicant = _service.GetList();

      return Ok(listApplicant);
    }
  }
}