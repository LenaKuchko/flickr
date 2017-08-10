using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;

namespace Flickr.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; internal set; }
    }
}
