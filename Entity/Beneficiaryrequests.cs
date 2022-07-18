using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShaqTamra.DAL.Extrnal;

namespace ShaqTamra.DAL.Entity
{
   public class Beneficiaryrequests
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfMeals { get; set; }
        public string Location { get; set; }
        public string DetailAddress { get; set; }
        public string BeneficiaryId { get; set; }

        public string State { get; set; }

    }
}
