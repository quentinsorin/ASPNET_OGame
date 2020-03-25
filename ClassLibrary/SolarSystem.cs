using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class SolarSystem :IDbEntity
    {
        private String name;
        private List<Planet> planets;
    }
}
