using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreIdentity.Extensions
{
    public static class EnvironmentVariableExtension
    {
        public static string GetConnectionStringFromEnvironment(this IConfiguration configuration, string name = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                return Environment.GetEnvironmentVariable("ASPNETCORE_DB_CONNECTION");
            }
            else
            {
                return Environment.GetEnvironmentVariable(name);
            }

        }
    }
}
