using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheGuildBoard.Models
{
    public class Message
    {
        public int? Id { get; set; }
        public int? SenderId { get; set; }
        public int ReceiverProperty { get; set; }
        public string Contents { get; set; }
    }
}
