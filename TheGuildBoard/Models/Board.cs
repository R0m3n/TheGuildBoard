﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGuildBoard.Models
{
    public class Board
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int OwnerId { get; set; }
    }
}
