using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Password
    {
        public string Id { get; set; }
        public string Website { get; set; }
        public string Login { get; set; }
        public string Passwords { get; set; }
    }
}