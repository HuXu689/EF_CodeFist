using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFist.Models
{
    public class Lop
    {
        [Key]
        public int LopId { get; set; }
        public string TenLop { get; set; }
        public int KhoaId { get; set; }
        public virtual Khoa Khoa { get; set; }
    }
}