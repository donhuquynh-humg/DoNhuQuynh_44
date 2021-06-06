using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoNhuQuynh_44.Models
{
    [Table("TinhThanhs")]
    public class TinhThanh
    {
        [Key]
        public string MaTinhThanh { get; set; }
        public string TenTinhThanh { get; set; }
    }
}