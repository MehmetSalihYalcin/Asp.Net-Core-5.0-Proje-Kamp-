using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Comment
    {
        [Key]

        public int ID { get; set; }

        public string? Comment_UserName { get; set; }

        public string? Comment_Title { get; set; }

        public string? Comment_Content { get; set; }

        public DateTime Comment_Date { get; set; }

        public bool Comment_Status { get; set; }

        [ForeignKey("Blog")]
        public int Blog_ID { get; set; }

        public Blog Blog { get; set; }
    }
}
