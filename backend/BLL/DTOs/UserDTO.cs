﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {
        public string? UserId { get; set; } = null;
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Login { get; set; }
        public string? UserRole { get; set; }

    }
}
