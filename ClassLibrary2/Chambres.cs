using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Chambres
    {
        public List<Chambres> ListChambres { get; set; }

        public Chambres()
        {
            this.ListChambres = new List<Chambres>();

        }
    }
}