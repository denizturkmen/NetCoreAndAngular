﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BackendApi.Model.Jwt.Dto
{
    public class UserForLoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
