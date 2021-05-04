using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGuildBoard.Models;

namespace TheGuildBoard.Data
{
    public class BoardContext : DbContext
    {
        public BoardContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Board> Boards { get; set; }

    }
}
