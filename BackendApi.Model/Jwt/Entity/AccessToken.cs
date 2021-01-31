﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BackendApi.Model.Jwt.Entity
{
    public class AccessToken
    {
        public string Token { get; set; }  // Token Değeri
        public DateTime Expiration { get; set; } // Token geçerlilik süresi
    }
}
