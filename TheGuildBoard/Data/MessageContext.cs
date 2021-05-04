using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheGuildBoard.Models;

namespace TheGuildBoard.Data
{
    public class MessageContext : DbContext
    {
        public MessageContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }

    }
}

