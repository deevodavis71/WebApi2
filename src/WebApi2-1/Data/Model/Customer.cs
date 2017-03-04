using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2_1.Data.Model
{
    [Table("Customers", Schema = "WebApi2-1")]
    public class Customer
    {
        public int CustomerId { get; set; }

        public String Firstname { get; set; }

        public String Surname { get; set; }
    }
}
