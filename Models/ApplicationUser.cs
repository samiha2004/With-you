﻿using Microsoft.AspNetCore.Identity;

namespace WithYou_project.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty; 
        public string LastName { get; set; } = string.Empty;
        
    }
}
