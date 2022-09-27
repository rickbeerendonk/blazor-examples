/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

public class CustomAuthenticationStateProvider1 : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var user = new ClaimsPrincipal(new NoIdentity());
        return Task.FromResult(new AuthenticationState(user));
    }

    private class NoIdentity : IIdentity
    {
        public string? Name { get; }
        public string? AuthenticationType { get; }
        public bool IsAuthenticated { get; }
    }
}