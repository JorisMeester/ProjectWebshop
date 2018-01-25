using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectWebshop.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [NotMapped]
        public string TitleShort
        {
            get
            {
                if (Name.Length < 40)
                {
                    return Name;
                }
                else
                {
                    return Name.Substring(0, 40);
                }
            }
        }
    }
}