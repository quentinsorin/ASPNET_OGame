using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FunctionBuidling : Building
    {
        [NotMapped]
        public List<Action> Actions()
        {
            return new List<Action>();
        }
    }
}
