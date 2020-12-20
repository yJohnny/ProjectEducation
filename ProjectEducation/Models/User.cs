﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjectEducation.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
        public string Name { get; set; }
    }
}
