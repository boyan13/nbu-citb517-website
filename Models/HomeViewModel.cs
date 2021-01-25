using CITB517_WebApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CITB517_WebApplication.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Comment> Comments { get; set; }

        public AddComment Create { get; set; }

        public DeleteComment Delete { get; set; }
    }
}
