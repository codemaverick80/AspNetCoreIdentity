using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.Data
{
    /*Default Implementation */
    //public class ApplicationDbContext : IdentityDbContext 
    //{
    //    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    //        : base(options)
    //    {
    //    }
    //}


    /* Extended Implemented */
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,string> 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
