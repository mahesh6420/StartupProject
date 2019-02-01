﻿using DailyStandup.Entities.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyStandup.Infrastructure.Interfaces.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<ApplicationUser>> GetNotFilledUsers();
    }
}
