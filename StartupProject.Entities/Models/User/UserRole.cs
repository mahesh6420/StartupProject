﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace StartupProject.Entities.Models.User
{
    public class UserRole : IdentityUserRole<string>
    {
        //public int UserId { get; set; }
        //public int RoleId { get; set; }

        //[ForeignKey("UserId")]
        //public ApplicationUser User { get; set; }

        //[ForeignKey("RoleId")]
        //public ApplicationRole Role { get; set; }
    }
}
