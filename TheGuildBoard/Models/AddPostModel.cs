using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGuildBoard.Models
{
    public class AddPostModel
    {
        public Board Board { get; set; }
        public List<Post> Posts { get; set; }
        public bool isAdmin { get; set; }



        public AddPostModel(Board board, List<Post> posts, bool admin)
        {
            this.Board = board;
            this.Posts = posts;
            this.isAdmin = admin;
        }
    }
}
