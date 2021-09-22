using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Passwords { get; set; }
        public int Role { get; set; }
    }
}
