using System.ComponentModel;
using Tratel.Contracts;
using Tratel.Contracts.Places;
using Tratel.Data.Managers;
using Tratel.Entities.Customer;

namespace Tratel.Common.Services.Repositories;

public class LookUpRepository
{
    
    public List<GuidOptionDto> GetNationalities()
    {
        var context = ConnectionManager.GetDbContext();
        return context.LookUps.Where(f => f.TypeId == Constants.CountryLookUpId)
                              .Select(f => new GuidOptionDto
                              {
                                  Id = f.Id,
                                  Text = f.Name
                              }).ToList();
    }
    public List<StringOptionDto> GetTown()
    {
        var context = ConnectionManager.GetDbContext();
        return context.LookUps.Where(f => f.TypeId == Constants.TownLookUpId)
                              .Select(f => new StringOptionDto
                              {                                  
                                  Text = f.Name
                              }).ToList();     
            
    }
  

}
