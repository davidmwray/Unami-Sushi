using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnamiSushi.Models
{
    public class Subcategory
    {
        [Key]
        public int SubcategoryID { get; set; }//pk
        public int CategoryID { get; set; }// fk
        public string SubcategoryName { get; set; }
        public string SubcategoryDescription { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
