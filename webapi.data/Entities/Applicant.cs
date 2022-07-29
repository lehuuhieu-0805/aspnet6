using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.data.Entities
{
  public class Applicant
  {
    public Guid Id { get; set; }
    public string Phone { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Status { get; set; } = null!;
  }
}