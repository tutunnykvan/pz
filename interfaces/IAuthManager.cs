﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.interfaces
{
    public interface IAuthManager
    {
        bool Login(string username, string password);
    }
}

