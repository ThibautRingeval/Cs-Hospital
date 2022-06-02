using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary2
{
    public class Employers
    {
        [JsonProperty(PropertyName = "hydra:member")]
        public List<Employer> ListEmployers { get; set; }

        public Employers()
        {
            this.ListEmployers = new List<Employer>();

        }
    }
}