using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Category
    {
        // Erişim Belirleyici Türü - Değişken Türü - İsim { get; set;}
        [Key]

        public int Category_ID { get; set; }

        public string? Category_Name { get; set; }

        public string? Category_Description { get; set; }

        public bool Category_Status { get; set; }

    }
}
