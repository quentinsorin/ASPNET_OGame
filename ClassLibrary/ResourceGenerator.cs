using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class ResourceGenerator : Building
    {
        
        private List<Resource> resourceBySecond;

        [NotMapped]
        public virtual List<Resource> ResourceBySecond
        {
            get { return resourceBySecond; }
            set { resourceBySecond = value; }
        }

        public ResourceGenerator()
        {
            this.resourceBySecond = new List<Resource>();
        }
    }
}
