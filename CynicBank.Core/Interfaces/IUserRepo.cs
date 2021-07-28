﻿using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Core.Models;

namespace CynicBank.Core.Interfaces
{
    public interface IUserRepo
    {
        bool AddNewUser(User userModel);

        bool CheckIfExits(string email);
    }
}
