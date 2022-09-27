/*! European Union Public License version 1.2 !*/
/*! Copyright © 2022 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Security_Authorization_RouterCascadingParameter;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Setup Autorization
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore(options =>
{
    options.AddPolicy("MemberPolicy", policyBuilder => policyBuilder.RequireClaim("Member"));
    options.AddPolicy("VipMemberPolicy", policyBuilder => policyBuilder.RequireClaim("Member", "0000", "0001"));
});

// Use fake AuthenticationStateProvider
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
await builder.Build().RunAsync();
