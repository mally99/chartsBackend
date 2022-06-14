using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
  public class SubscriberDTO
  {
    public int IdSubscriber { get; set; }
    public string NameSubscriber { get; set; }
    public Nullable<int> IdCustomer { get; set; }
  }
}
