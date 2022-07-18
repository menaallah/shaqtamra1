using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShaqTamra.DAL.Entity
{
    [Table("Order")]

    public class Order
    {
        public int Id { get; set; }
        public int NumberOfMeals { get; set; }
        public DateTime Date { get; set; }

        public string DonerId { get; set; }

        public string Beneficiary_Id { get; set; }

        public string Volunteer_Id { get; set; }

        public string DetailAddress { get; set; }

        public string Location { get; set; }

        public bool Active { get; set; }


    }
}
