using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGuildBoard.Models;

namespace TheGuildBoard.Data
{
    class PostContext : DbContext
    {
        public PostContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
    }

}

