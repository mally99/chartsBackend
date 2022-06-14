using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;


namespace BL.Services
{
  public interface ICustomerService
  {
    CustomerDTO GetCustomer(int id);
    List<SubscriberDTO> GetSubscribersForCustomer(int id);
    List<ReturnPackagesDTO> GetPacksForSubscriber(int subId);

  }
  public class CustomerService : ICustomerService
  {
    CellPhoneDBEntities DB = new CellPhoneDBEntities();
   // DBCellPhoneRMEntities DB = new DBCellPhoneRMEntities();
    public CustomerService()
    {
        
    }
    public CustomerDTO GetCustomer(int id)
    {
      var cust = DB.CustomerTbl.Where(x => x.IdCustomer == id).Select(x => new CustomerDTO()
      {
        IdCustomer = x.IdCustomer,
        FirstName = x.FirstName,
        LastName = x.LastName,
        Identity = x.Identity,
        Addsress = x.Addsress

      }).FirstOrDefault();
      return cust;
    }
    public List<SubscriberDTO> GetSubscribersForCustomer(int id)
    {
      List<SubscriberDTO> subscribers = new List<SubscriberDTO>();
      subscribers = DB.SubscriberTbl.Where(x => x.IdCustomer == id).Select(x =>
       new SubscriberDTO()
       {
         IdCustomer = x.IdCustomer,
         IdSubscriber = x.IdSubscriber,
         NameSubscriber = x.NameSubscriber
       }).ToList();
      return subscribers;
    }
    //public List<PackDTO> GetPacksForSubscribers(int idSub)
    //{
    //  return DB.PackTbl.Where(x => x.SubscriberPacksTbl.Any(y => y.IdSubscriber == idSub))
    //     .Select(x => new PackDTO
    //     {
    //       IdPack = x.IdPack,
    //       NamePack = x.NamePack,
    //       QtyMiutes = x.QtyMiutes
    //     }).ToList();
    //}
    public List<ReturnPackagesDTO> GetPacksForSubscriber(int subId)
    {
      List<ReturnPackagesDTO> tempList = new List<ReturnPackagesDTO>();

      foreach (SubscriberPacksTbl p in DB.SubscriberPacksTbl.Where(x => x.IdSubscriber == subId).ToList())
      {
        var c = DB.PackTbl.Where(y => y.IdPack == p.IdPack).Select(e => new ReturnPackagesDTO() { NamePack = e.NamePack, UsingMinutes = p.UsingMinutes,QtyMinutes = e.QtyMiutes }).FirstOrDefault();
        tempList.Add(c);
      }
      return tempList;
    }
  }
}
