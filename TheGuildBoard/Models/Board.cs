using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheGuildBoard.Models
{
    public class Board
    {
        
        public int? Id { get; set; }
        public string Title { get; set; }
        public string OwnerEmail { get; set; }


        public Board(string title, string owneremail)
        {
            this.Title = title;
            this.OwnerEmail = owneremail;
        }

        public Board()
        {

        }
    }
   
}
