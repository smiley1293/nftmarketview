using System;
using System.Collections.Generic;

namespace NFTMatketViewBusinessObject.Models
{
    public partial class Account
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string? Fullname { get; set; }
        public int RoleId { get; set; }
    }
}
