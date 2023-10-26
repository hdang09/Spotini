using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
