using System.Collections.Generic;
using IdentityServer8.Models;

namespace NetDevPack.Security.Jwt.IdentityServer8.Tests
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };
        }

        public static IEnumerable<ApiResource> GetApis()
        {
            return new ApiResource[] { };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new Client[] { };
        }
    }
}
