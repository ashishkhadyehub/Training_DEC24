using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Models
{
    public class State
    {
        public int Id { get; set; }

        public string Name { get; set; } = "MH";

        [DisplayName("Country Name")]
        public int CountryId { get; set; }

        //Navigation Properties

        public Country? Country { get; set; }

        public ICollection<District> districts { get; set; }=new HashSet<District>();


    }
}
