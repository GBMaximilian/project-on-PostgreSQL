using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PG2
{
    public class Car
    {
        [Key]
        public string LicenceNumber { get; set; }
        public string Insurance { get; set; }
        public string Hu { get; set; }
        public string Nya { get; set; }
        public string GBT { get; set; }
        public int LGBT { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
        public Car()
        {
            this.Persons = new List<Person>();
        }

        public override string ToString()
        {
            return LicenceNumber;
        }
    }
}
