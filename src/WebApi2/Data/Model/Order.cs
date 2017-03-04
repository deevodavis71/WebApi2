using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Data.Model
{
    [Table ("Orders", Schema = "WebApi2")]
    public class Order
    {
        public int OrderId { get; set; }
        public String OrderNumber { get; set; }
    }
}
