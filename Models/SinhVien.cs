using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFist.Models
{
    public class SinhVien
    {
        [Key]
        public int SinhVienId { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public int LopId { get; set; }
        public virtual Lop Lop { get; set; }
    }
}