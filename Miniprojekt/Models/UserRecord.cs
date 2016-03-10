using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Miniprojekt.Models
{
    public enum CategoryType
    {
        PictureOnScreen,
        TextOnScreen,
        ColorOnScreen,
        WordOnScreen,
        Challenge
    }

    public class UserRecord
    {
        [Key]
        public int RecordID { get; set; }
        [DisplayName("Kategori")]
        public CategoryType Category { get; set; }

        [DisplayName("Smeknamn")]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual UserName username { get; set; }

        [DisplayName("Poäng")]
        public int Points { get; set; }
    }
}