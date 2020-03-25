using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Planet : IDbEntity
    { 
      
        private long? id;
        private String name;
        private int? caseNb;
        private List<Resource> resources;
        private List<Building> buildings;
     

        
        [StringLength(20, MinimumLength = 5)]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [IntegerValidator(MinValue = 0, MaxValue = int.MaxValue)]
        public int? CaseNb
        {
            get { return caseNb; }
            set { caseNb = value; }
        }

        public virtual List<Resource> Resources
        {
            get { return resources; }
            set { resources = value; }
        }

        
        [NotMapped]
        public virtual List<Building> Buildings
        {
            get { return buildings; }
            set { buildings = value; }
        }

        public virtual long? Id { get => this.id; set => this.id = value; }
       
        public Planet()
        {
            this.buildings = new List<Building>();
            this.resources = new List<Resource>();
        }
       
    }
}
