using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Resource : IDbEntity
    {
        private string name { get; set; }
        private int? lastQuantity { get; set; }
        private DateTime lastUpdate { get; set; }

    }
}
