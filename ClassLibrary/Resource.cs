using ClassLibrary.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Resource : IDbEntity
    {
        
        private long? id;
        private String name;
        private int? lastQuantity;
        private DateTime lastUpdate;
        
        [StringLength(20, MinimumLength = 5)]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [Range(0, int.MaxValue)]
        public int? LastQuantity
        {
            get { return lastQuantity; }
            set { lastQuantity = value; }
        }

        [ValidatorDateTime]
        public DateTime LastUpdate
        {
            get { return lastUpdate; }
            set { lastUpdate = value; }
        }
        
        public virtual long? Id { get => this.id; set => this.id = value; }

        

    }
}
