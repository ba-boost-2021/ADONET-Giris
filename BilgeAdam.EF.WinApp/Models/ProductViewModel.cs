using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.EF.WinApp.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }
    }
}
