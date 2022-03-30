using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tratel.Contracts.Places;
using Tratel.Data.Managers;

namespace Tratel.Common.Services.Repositories
{
    public  class PlaceRepository
    {
        public List<PlaceListDto> GetPlace()
        {
            var context = ConnectionManager.GetDbContext();
            var town = new LookUpRepository();
            return context.Places.Select(f => new PlaceListDto
            {
                Name = f.Name,
                Address = f.Address,
                Phone = f.Phone,
                Town = f.Town.ToString(),
                Type = f.Type,

            }).ToList();


        }
        
    }
}
