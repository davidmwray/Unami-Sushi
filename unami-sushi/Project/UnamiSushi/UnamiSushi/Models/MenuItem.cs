using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnamiSushi.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemID { get; set; } //Primary Key

        public int SubcategoryID { get; set; }// foreign key
      
        public string MenuItemName { get; set; } //Short name of the particular dish

        public int Piece { get; set; }// amount of pieces in a rolls ex: 8pc, 5pc, 10pc, etc. can be null

        public bool Cooked { get; set; }// if item is cooked=true, raw=false

        public bool Vegetarian { get; set; }// if item is vegetarian = true

        public string MenuItemDescription { get; set; } //Contains a description of the menu item

        public double MenuItemPrice { get; set; } //Lists the current price of the menu item

        //public string PicturePathname { get; set; } //obsolete, linked to separate menu picture item with picture and thumbnail
        //public string ThumbnailPathname { get; set; } 


        public virtual ICollection<MenuPicture> MenuPictures { get; set; }
    }
}