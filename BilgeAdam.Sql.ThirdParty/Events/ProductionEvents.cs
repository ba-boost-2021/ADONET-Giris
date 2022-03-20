using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Sql.ThirdParty.Events
{
    public class ProductionEvents
    {
        public event ProductAddedEventHandler OnProductAdded;

        public void ProductAdded()
        {
            if(OnProductAdded != null)
            {
                OnProductAdded.Invoke();
            }
        }
    }

    public delegate void ProductAddedEventHandler();
}
