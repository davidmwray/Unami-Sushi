using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnamiSushi.Models
{
    public class Reply
    {
        public int ReplyID { get; set; } //Primary key, unique identifier for reply objects

        public int CommentID { get; set; } //Foreign key identifier to comment this is replying to

        public int UserID { get; set; } //Foreign key identifier for replying user

        public DateTime CommentDate { get; set; } //Date reply was made

        public string CommentContents { get; set; } //The users reply
    }
}