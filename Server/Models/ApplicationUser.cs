﻿using Microsoft.AspNetCore.Identity;

namespace SmartphonePortal_Vervoort_Wagner.Server.Models;

public class ApplicationUser : IdentityUser
{
    public List<Comment> Comments { get; set; } = new();
    public List<Review> Reviews { get; set; } = new();
}