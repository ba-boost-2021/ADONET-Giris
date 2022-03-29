using Tratel.Contracts;
using Tratel.Data.Managers;

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
    
}
