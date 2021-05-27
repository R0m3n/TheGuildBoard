using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGuildBoard.Models;

namespace TheGuildBoard
{
    public interface IDataAccessLayer
    {
        List<Post> GetPosts(int BoardId);

        void AddPost(Post post);
        void AddBoard(Board board);

        void DeletePost(int id);

        Post GetPostById(int id);

        Board GetBoardByName(string title);
        Board GetBoardById(int id);

    }
}
