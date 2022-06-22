using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ValhallaApp.Application.Requests;

namespace ValhallaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpPost]

        public IActionResult GetToken(UserLoginRequest loginRequest)
        {
            var isValidUser = ValidateUser(loginRequest);
            if (!isValidUser)
            {
                return Unauthorized();
            }
            var token = GenerateToken(loginRequest.Username);
            return Ok(new {token});
        }

        private bool ValidateUser(UserLoginRequest loginRequest)
        {
            if (loginRequest.Username == "Admin" && loginRequest.Password == "Admin")
            {
                return true;
            }
            return false;
        }

        private string GenerateToken(string Username)
        {
            //header
            var privateKey = "v1d1g17dghf56g4d6gfd84gdd56fg4dfgddfg8";
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(privateKey));
            var signinCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(signinCredentials);

            //payload

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, Username),
                new Claim(ClaimTypes.Role, "Admin"),
            };

            var payload = new JwtPayload
                (
                    "https://localhost:44363",
                    "https://localhost:44363",
                    claims,
                    DateTime.Now,
                    DateTime.Now.AddMinutes(5)
                );

            //signature

            var token = new JwtSecurityToken(header, payload);
            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }
    }
}
