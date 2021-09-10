using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiTap.Models
{
    public class Person
    {
        [Key]
        [Required(ErrorMessage = "Chưa nhập ID")]
        public string PersonID { get; set; }
        [Required(ErrorMessage ="Chưa nhập Tên")]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "Chưa nhập địa chỉ")]
        public string address { get; set; }
    }
}