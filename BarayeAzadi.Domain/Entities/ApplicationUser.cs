﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarayeAzadi.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime CreatedAt   { get; set; }

    }

}
