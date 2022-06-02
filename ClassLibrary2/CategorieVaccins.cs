using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class CategorieVaccins
    {
        public List<CategorieVaccins> ListCategorieVaccins { get; set; }

        public CategorieVaccins()
        {
            this.ListCategorieVaccins = new List<CategorieVaccins>();

        }
    }
}