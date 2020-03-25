using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class FunctionBuidling : Building
    {
       
        private List<Action> actions;
       
        [NotMapped]
        public virtual List<Action> Actions
        {
            get { return actions; }
            set { actions = value; }
        }


        public FunctionBuidling()
        {
            this.actions = new List<Action>();
        }
      
    }
}
