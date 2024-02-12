/*! European Union Public License version 1.2 !*/
/*! Copyright © 2024 Rick Beerendonk          !*/

using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Components.Authorization;

namespace Security_Authorization_RouterCascadingParameter;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private bool isAuthenticated = false;

    public CustomAuthenticationStateProvider()
    {
        DelayedAuthentication();
    }

    private async Task DelayedAuthentication()
    {
        await Task.Delay(TimeSpan.FromSeconds(3));
        isAuthenticated = true;
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    private Task<AuthenticationState> GetLoggedInAuthenticationStateAsync()
    {
        const string issuer = "https://security.oblicum.com";

        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, "Alexandra", ClaimValueTypes.String, issuer),
            new Claim(ClaimTypes.Surname, "Adams", ClaimValueTypes.String, issuer),
            new Claim(ClaimTypes.Country, "Australia", ClaimValueTypes.String, issuer),
            new Claim("Member", "123", ClaimValueTypes.String, issuer)
        }, "Fake authentication type");

        var user = new ClaimsPrincipal(identity);

        return Task.FromResult(new AuthenticationState(user));
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        if (isAuthenticated)
        {
            return GetLoggedInAuthenticationStateAsync();
        }
        else
        {
            var user = new ClaimsPrincipal(new NoIdentity());
            return Task.FromResult(new AuthenticationState(user));
        }
    }

    private class NoIdentity: IIdentity {
        public string? Name { get; }
        public string? AuthenticationType { get; }
        public bool IsAuthenticated { get; }
    }
}