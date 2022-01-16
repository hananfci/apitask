using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace task.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string streetName { get; set; }

        [ForeignKey("personId")]
        public int personId { get; set; }
        public Person person { get; set; }
    }
}
