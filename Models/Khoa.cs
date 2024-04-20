using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFist.Models
{
    public class Khoa
    {
        [Key]
        public int KhoaId { get; set; }
        public string TenKhoa { get; set; }
    }
}