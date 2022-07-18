using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ShaqTamra.DAL.Extrnal;

namespace ShaqTamra.DAL.Entity
{
    [Table("Comment")]

    public class  Comment
    {
       
        public int Id { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
        public DateTime Date { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public string applicationUserId { get; set; }
    }
}
