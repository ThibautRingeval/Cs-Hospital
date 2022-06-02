using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Lits
    {
        public List<Lits> ListLits { get; set; }

        public Lits()
        {
            this.ListLits = new List<Lits>();

        }
    }
}