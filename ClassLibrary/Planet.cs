using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Planet : IDbEntity
    {
        private String name;
        private int? caseNb;

        private List<Resource> resources;
        private List<Building> buildings;
    }
}
