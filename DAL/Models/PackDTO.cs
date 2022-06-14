using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
  public class PackDTO
  {
    public int IdPack { get; set; }
    public string NamePack { get; set; }
    public Nullable<int> QtyMiutes { get; set; }
  }
}
