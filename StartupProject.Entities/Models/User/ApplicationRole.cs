﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DailyStandup.Entities.Models.User
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationRole : IdentityRole
    {
        public string Descriminator { get; set; }

        public IEnumerable<UserRole> UserRole { get; set; }
    }
}
