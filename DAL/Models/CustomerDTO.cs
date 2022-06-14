using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
 public class CustomerDTO
  {
    public int IdCustomer { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Identity { get; set; }
    public string Addsress { get; set; }
  }
}
