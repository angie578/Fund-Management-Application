﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundManagementApplication.Interfaces {
    public interface IJWTAuthenticationManager {
        string Authenticate(string email);
    }
}
