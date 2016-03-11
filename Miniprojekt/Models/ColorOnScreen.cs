using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models
{
    public class ColorOnScreen
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Färg namn")]
        public string Name { get; set; }
        [DisplayName("RGB kod")]
        public string rgb { get; set; }
    }
}