 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Models
{
    public class Customer
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Mail { get; set; }

        public int Age { get; set; }

        public DateTime? Birthday { get; set; }



        // Adressi index olarak kullanmak istememden dolayı IList kullanıyorum
        //Customer.Address[1].ID 
        public IList<Address> Addresses { get; set; }


        public Gender Gender { get; set; }
    }
}
