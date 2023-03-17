using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Blog
    {
        [Key]

        public int Blog_ID { get; set; }

        public string? Blog_Title { get; set; }

        public string? Blog_Content { get; set; }

        public string? Blog_ThumbNailImage { get; set; } // büyük resim

        public string? Blog_Image { get; set; }

        public DateTime Blog_CreateDate { get; set; }

        public bool Blog_Status { get; set; }

        public int Category_ID { get; set; }
        public Category? Category { get; set; }

        public List<Comment>? Comments { get; set; }
    }
}
