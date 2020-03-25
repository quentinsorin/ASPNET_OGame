using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FunctionBuidling : Building
<<<<<<< HEAD

=======
>>>>>>> 98d1c0a2188d80bcf42a96671d9f156557e7ca73
    {
        [NotMapped]
        public List<Action> Actions()
        {
            return new List<Action>();
        }
    }
}
