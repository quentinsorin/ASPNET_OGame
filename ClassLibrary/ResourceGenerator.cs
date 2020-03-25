using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ResourceGenerator : Building
    {
        [NotMapped]
        private List<Resource> resourceBySecond = new List<Resource>();

        public virtual List<Resource> ResourceBySecond
        {
            get { return resourceBySecond; }
            set { resourceBySecond = value; }
        }
    }
}
