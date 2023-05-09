using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Category")]
        public int Category_ID { get; set; }
        public Category? Category { get; set; }


		[ForeignKey("Writer")]
		public int Writer_ID { get; set; }
		public Writer? Writer { get; set; }
	}
}
