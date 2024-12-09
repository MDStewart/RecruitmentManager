namespace RecruitmentManager.Services;

using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

public class HRMSAuthStateProvider : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var identity = new ClaimsIdentity(
            [
                new Claim(ClaimTypes.Name, "")
            ], "Custom Authentication");
        
        var user = new ClaimsPrincipal(identity);

        return Task.FromResult(new AuthenticationState(user));
        
    }
}
