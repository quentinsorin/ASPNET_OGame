using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Resource : IDbEntity
    {
        private string Name { get; set; }
        private int? LastQuantity { get; set; }
        private DateTime LastUpdate { get; set; }

    }
}
