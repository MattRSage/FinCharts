using FinCharts.Application.Common.Interfaces.Authentication;

namespace FinCharts.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // Check if user already exists
        
        // Create user
        
        // Create JWT token
        var userId = Guid.NewGuid();
        
        var token = _jwtTokenGenerator.CreateToken(userId, firstName, lastName);
        
        return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
    }
}