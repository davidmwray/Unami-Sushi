using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnamiSushi.Models
{
    public class Comment
    {
        public int CommentID { get; set; } //Primary key, unique identifier for comment objects

        public int MenuItemID { get; set; } //Foreign key identifier to menu item

        public int UserID { get; set; } //Foreign key identifier for commenting user

        public DateTime CommentDate { get; set; } //Date comment was made

        public string CommentContents { get; set; } //The users comment
    }
}