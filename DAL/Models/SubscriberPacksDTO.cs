using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
  class SubscriberPacksDTO
  {
    public int IdSubscriber { get; set; }
    public int? IdPack { get; set; }
    public int? UsingMinutes { get; set; }
    public SubscriberPacksDTO()
    {

    }
  }
  public class ReturnPackagesDTO
  {
    public string NamePack { get; set; }
    public int? QtyMinutes { get; set; }
    public int? UsingMinutes { get; set; }
  }
}
