using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnamiSushi.Models
{
    public class MenuCategory
    {
        [Key]
        public int CategoryID { get; set; } //Primary Key
        public string CategoryName { get; set; } //Name of a menu category
        public string CategoryDescription { get; set; } //Description of dishes in a menu category


        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }
}