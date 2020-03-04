using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DATA.Entities
{
    [Table("student")]
   public class student
    {
        [Key]
        [DisplayName("id")]
        public int id { get; set; }
        [DisplayName("姓名")]
        [Required]
        public string name { get; set; }
        [DisplayName("年龄")]
        public int age { get; set; }
        [DisplayName("时间")]
        public DateTime? time { get; set; }


    }
}
