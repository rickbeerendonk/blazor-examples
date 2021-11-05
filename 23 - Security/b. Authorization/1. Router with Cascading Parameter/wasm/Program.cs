/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Security_Authorization_RouterCascadingParameter
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            builder.RootComponents.Add<App>("#app");

            // Setup Autorization
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore(options =>
            {
                options.AddPolicy("MemberPolicy", policyBuilder => policyBuilder.RequireClaim("Member"));
                options.AddPolicy("VipMemberPolicy", policyBuilder => policyBuilder.RequireClaim("Member", "0", "1"));
            });

            // Use fake AuthenticationStateProvider
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            await builder.Build().RunAsync();
        }
    }
}
