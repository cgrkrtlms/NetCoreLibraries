using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.Models
{
    public class Address
    {
        public int ID { get; set; }

        public string Content { get; set; }

        public string Province { get; set; }

        public string PostCode { get; set; }


        // virtual vermemizin amacı entity framework'ün entity üzerinde crud işlemlerini izleyebilmesi için 
        public virtual Customer Customer { get; set; }
    }
}
