using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShaqTamra.DAL.Entity
{
    [Table("Post")]

    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string ImageName { get; set; }
        public ICollection<Comment>   Comment { get; set; }

        public ICollection<Like> Like { get; set; }

    }
}
