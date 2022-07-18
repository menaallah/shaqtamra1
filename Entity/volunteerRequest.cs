using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShaqTamra.DAL.Entity
{
    [Table("volunteerRequest")]
    public class volunteerRequest
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ResponseDate { get; set; }
        public Order Order { get; set; }

        public int  OrderId { get; set; }
        public string VolunteerId { get; set; }

        public string State { get; set; }
    }
}
