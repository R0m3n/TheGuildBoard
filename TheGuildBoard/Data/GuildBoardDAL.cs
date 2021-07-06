using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGuildBoard.Models;

namespace TheGuildBoard.Data
{
    public class GuildBoardDAL : IDataAccessLayer
    {
        

        private PostContext _posts;
        private BoardContext _boards;


        public GuildBoardDAL(PostContext posts, BoardContext boards)
        {
            this._posts = posts;
            this._boards = boards;
        }

        public void DeletePost(int id)
        {
            Post post = GetPostById(id);
            _posts.Posts.Remove(post);
            _posts.SaveChanges();
        }

        public List<Post> GetPosts(int BoardId)
        {
            return _posts.Posts.Where(p => p.BoardId == BoardId).ToList();
        }

        public Post GetPostById(int id)
        {
            return _posts.Posts.Where(p => p.Id == id).FirstOrDefault();
        }

        void IDataAccessLayer.AddPost(Post post)
        {
            _posts.Posts.Add(post);
            _posts.SaveChanges();
        }

        public void AddBoard(Board board)
        {
            _boards.Boards.Add(board);
            _boards.SaveChanges();
        }

        public Board GetBoardByName(string title)
        {
            return _boards.Boards.Where(b => b.Title == title).FirstOrDefault();
        }

        public Board GetBoardById(int id)
        {
            return _boards.Boards.Where(b => b.Id == id).FirstOrDefault();
        }

        public List<Board> GetBoardsByOwnerEmail(string owneremail)
        {
            List<Board> boards = _boards.Boards.Where(b => b.OwnerEmail == owneremail).ToList();
            return boards; 
        }
    }
}
