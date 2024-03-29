﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity.Models;
using Entitties.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IAuthManager
    {
        void Register(RegisterDTO model);
        User GetUserByEmail(string email);
        User Login(string email);
        List<User> GetUsers();
       
    }
}
