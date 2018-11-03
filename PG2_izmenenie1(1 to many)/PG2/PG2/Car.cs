using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PG2
{
    public class Car
    {
        [Key]
        public string LicenceNumber { get; set; }        
        public int? Year { get; set; }

        
        public int? PersonID { get; set; }
        [ForeignKey("PersonID")]
        public Person Person { get; set; }
        public Car()
        {
           
        }

        public override string ToString()
        {
            return LicenceNumber;
        }
    }
}
