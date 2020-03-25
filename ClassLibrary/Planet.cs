using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Planet : IDbEntity
    {
        private String Name { get; set; }
        private int? CaseNb { get; set; }

        private List<Resource> Resources { get; set; } = new List<Resource>();
        private List<Building> Buildings { get; set; } = new List<Building>();
    }
}
