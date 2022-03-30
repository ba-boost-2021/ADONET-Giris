using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tratel.Common.Enums;
using Tratel.Entities.Main;

namespace Tratel.Contracts.Places
{
    public class PlaceListDto
    {
        public string Name { get; set; }

       
        public string Phone { get; set; }

        public PlaceType Type { get; set; }

     
        public string Town { get; set; }

       
        public string Address { get; set; }

       
    }

}
