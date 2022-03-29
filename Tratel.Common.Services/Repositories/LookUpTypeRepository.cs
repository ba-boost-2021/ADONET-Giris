using Tratel.Contracts;
using Tratel.Data.Managers;
using Tratel.EndUser.LookUpTypes;
using Tratel.Entities.Main;

namespace Tratel.Common.Services.Repositories;

public class LookUpTypeRepository
{
    public List<GuidOptionDto> GetAllTypes()
    {
        var context = ConnectionManager.GetDbContext();
        return context.LookUpTypes.Select(x => new GuidOptionDto
        {
            Id = x.Id,
            Text = x.Name
        }).ToList();
    }

    public bool CreateLookUpType(NewLookUpTypeDto data)
    {
        var context = ConnectionManager.GetDbContext();

        context.LookUpTypes.Add(new LookUpType
        {
            Name = data.Name,
            CreatedAt = data.CreateAt,
            ModifiedAt = data.ModifiedAt,
        });
        var result = context.SaveChanges();

        return result == 1;
    }

    public bool UpdateLookUpType(Guid Id, string name)
    {
        var context = ConnectionManager.GetDbContext();
        var lookUpType = context.LookUpTypes.SingleOrDefault(x => x.Id == Id);
        if (lookUpType == null)
        {
            return false;
        }
        lookUpType.Name = name;
        var result = context.SaveChanges();
        return result == 1;
    }

    public bool DeleteSelectedType(string selectedTypeName)
    {
        var context = ConnectionManager.GetDbContext();

        var data = context.LookUpTypes.Where(x => x.Name == selectedTypeName).First();

        context.LookUpTypes.Remove(data);
        var result = context.SaveChanges();
        return result == 1;
    }
}
