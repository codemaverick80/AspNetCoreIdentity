using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Models
{
    /*
     * By default IdentityUser class used by Identity framework.
     * This class only capture UserName, Email and Password.
     *
     * Since we need to capture more information about the user, we need to extend this class.
     *
     * Here we have created ApplicationUser class and inherit it from IdentityUser class.
     * which mean ApplicationUser class is specialized version of IdentityUser class.
     */
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser():base(){}

        // We want to add two Extra properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
