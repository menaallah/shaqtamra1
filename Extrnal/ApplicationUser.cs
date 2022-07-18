using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ShaqTamra.DAL.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShaqTamra.DAL.Extrnal
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name ="PhoneNumber")]
        public string UserName2 { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string DonationRate { get; set; }
        public int DonationNumber { get; set; }

        public string DetailAddress { get; set; }

        public ICollection<Like> Like { get; set; }
        public ICollection<Comment> Comment { get; set; }

    }
}
