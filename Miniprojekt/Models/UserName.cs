using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models
{
    public class UserName
    {
        [Key]
        public int UserID { get; set; }
        [DisplayName("Smeknamn")]
        public string NickName { get; set; }
    }
}