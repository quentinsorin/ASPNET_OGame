using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SolarSystem :IDbEntity
    {
        private string Name { get; set; }
        private List<Planet> planets { get; set; } = new List<Planet>();
    }
}
