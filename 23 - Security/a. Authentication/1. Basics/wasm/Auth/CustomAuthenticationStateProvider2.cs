/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

public class CustomAuthenticationStateProvider2 : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        const string issuer = "https://security.oblicum.com";

        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, "Alexandra", ClaimValueTypes.String, issuer),
            new Claim(ClaimTypes.Surname, "Adams", ClaimValueTypes.String, issuer),
            new Claim(ClaimTypes.Country, "Australia", ClaimValueTypes.String, issuer),
            new Claim("Member", "2", ClaimValueTypes.String, issuer)
        }, "Fake authentication type");

        var user = new ClaimsPrincipal(identity);

        return Task.FromResult(new AuthenticationState(user));
        //return Task.FromResult(null);
    }
}