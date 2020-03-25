using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Planet : IDbEntity
    {
        private String name { get; set; }
        private int? caseNb { get; set; }

        private List<Resource> resources { get; set; } = new List<Resource>();
        private List<Building> buildings { get; set; } = new List<Building>();
    }
}
