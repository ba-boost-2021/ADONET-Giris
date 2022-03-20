using BilgeAdam.Sql.ThirdParty.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Sql.ThirdParty.Managers
{
    public static class EventManager
    {
        static EventManager() // static constructor. Bütün class'ların static constructorı vardır.Static üyeler oluşturulmadan çalışır. Uygulama boyunca yalnızca bir kere çalışır
        {
            ProductionEvents = new ProductionEvents();
        }
        public static ProductionEvents ProductionEvents { get; set; }
    }
}
