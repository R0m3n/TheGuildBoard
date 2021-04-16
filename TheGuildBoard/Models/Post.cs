using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGuildBoard.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime Date { get; set; }
    }
}
