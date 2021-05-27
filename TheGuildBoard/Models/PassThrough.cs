using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGuildBoard.Models
{
    public class PassThrough
    {
        public PassThrough(Post post, Board board, bool admin)
        {
            Post = post;
            Board = board;
            IsAdmin = admin;
        }

        public Post Post { get; set; }
        public Board Board { get; set; }
        public bool IsAdmin { get; set; }
    }
}
