using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreInterface
{
    public class User
    {
        [Key]
        public int? UserID { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Car> Cars { get; set; }
        public User()
        {
            this.Cars = new List<Car>();
        }

    }

    public class Car
    {
        [Key]
        public string LicenceNumber { get; set; }
        public int? Year { get; set; }

        public int? UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public Car()
        {

        }

        public override string ToString()
        {
            return LicenceNumber;
        }
    }
}
