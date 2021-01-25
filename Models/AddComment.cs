using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CITB517_WebApplication.Models
{
    public class AddComment
    {
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
