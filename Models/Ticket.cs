using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTicketAdminApp.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Genre { get; set; }
        public string Image { get; set; }
    }
}
