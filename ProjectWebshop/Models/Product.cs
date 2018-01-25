using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectWebshop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [NotMapped]
        public string NameShort
        {
            get
            {
                if (Name.Length < 30)
                {
                    return Name;
                }
                else
                {
                    return Name.Substring(0, 30);
                }
            }
        }

        [NotMapped]
        public string DescriptionShort
        {
            get
            {
                if (Description.Length < 40)
                {
                    return Description;
                }
                else
                {
                    return Description.Substring(0, 40);
                }
            }
        }
    }
}