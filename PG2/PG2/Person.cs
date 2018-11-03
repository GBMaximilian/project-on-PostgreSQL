using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Car> Cars { get; set; }
        public Person()
        {
            this.Cars = new List<Car>();
        }

    }
}
