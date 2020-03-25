using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SolarSystem :IDbEntity
    {
		private long? id;
		private String name;
		private List<Planet> planets;
		
		
		[StringLength(20, MinimumLength = 5)]
		public String Name
		{
			get { return name; }
			set { name = value; }
		}

		public virtual List<Planet> Planets
		{
			get { return planets; }
			set { planets = value; }
		}

		public virtual long? Id { get => this.id; set => this.id = value; }

		public SolarSystem()
		{
			this.planets = new List<Planet>();
		}
	}
}
