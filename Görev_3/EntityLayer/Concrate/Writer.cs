using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Writer
    {
        [Key]

        public int ID { get; set; }

        public string? Writer_Name { get; set; }

        public string? Writer_About { get; set; }

        public string? Writer_Image { get; set; }

        public string? Writer_Mail { get; set; }

        public string? Writer_Password { get; set; }

        public bool Writer_Status { get; set; }


		[ForeignKey("City")]
		public int City_ID { get; set; }
		public City City { get; set; }


	}
}
