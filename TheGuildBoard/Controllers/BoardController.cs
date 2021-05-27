using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TheGuildBoard.Models;

namespace TheGuildBoard.Views
{
    [Authorize]
    public class BoardController : Controller
    {
        IDataAccessLayer dataAccessLayer;

        public BoardController(IDataAccessLayer dal)
        {
            dataAccessLayer = dal;
        }
        public IActionResult Index()
        {
            int id;
            if(Request.RouteValues["id"] != null)
            {
                id = int.Parse(Request.RouteValues["id"].ToString());
                Board board = dataAccessLayer.GetBoardById(id);

                bool admin;
                if (User.FindFirst(ClaimTypes.Email).ToString() == board.OwnerEmail)
                {
                    admin = true;
                }
                else
                {
                    admin = false;
                }

                AddPostModel model = new AddPostModel(board, dataAccessLayer.GetPosts(id), admin);

                return View(model);
            }


            return RedirectToAction("Index", "Home");
        }

        public IActionResult AddPost(int BoardId)
        {
            return View(BoardId);
        }

        public IActionResult SubmitPost(string title, string contents, int boardid)
        {
            Post post = new Post(title, contents);
            post.BoardId = boardid;
            dataAccessLayer.AddPost(post);

            Board board = dataAccessLayer.GetBoardById(boardid);
            bool admin;
            if (User.FindFirst(ClaimTypes.Email).ToString() == board.OwnerEmail)
            {
                admin = true;
            }
            else
            {
                admin = false;
            }

            AddPostModel model = new AddPostModel(board, dataAccessLayer.GetPosts(boardid), admin);

            return View("Index", model);
        }

        public IActionResult DeletePost(int id, int boardid)
        {
            dataAccessLayer.DeletePost(id);

            Board board = dataAccessLayer.GetBoardById(boardid);

            bool admin;
            if (User.FindFirst(ClaimTypes.Email).ToString() == board.OwnerEmail)
            {
                admin = true;
            }
            else
            {
                admin = false;
            }

            AddPostModel model = new AddPostModel(board, dataAccessLayer.GetPosts(boardid), admin);

            return View("Index", model);
        }

        public IActionResult ViewPost()
        {
            int id;
            if (Request.RouteValues["id"] != null)
            {
                id = int.Parse(Request.RouteValues["id"].ToString());
                Post post = dataAccessLayer.GetPostById(id);

                return View(post);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult CreateBoard()
        {
            return View();
        }


        public IActionResult AddBoard(string title)
        {
            Board board = new Board(title, User.FindFirst(ClaimTypes.Email).ToString());
            dataAccessLayer.AddBoard(board);

            int? boardid = dataAccessLayer.GetBoardByName(title).Id;
            Board board2 = dataAccessLayer.GetBoardById((int)boardid);

            bool admin;
            if (User.FindFirst(ClaimTypes.Email).ToString() == board2.OwnerEmail)
            {
                admin = true;
            }
            else
            {
                admin = false;
            }

            AddPostModel model = new AddPostModel(board2, dataAccessLayer.GetPosts((int)boardid), admin);
            return View("Index", model);
        }
    }
}
