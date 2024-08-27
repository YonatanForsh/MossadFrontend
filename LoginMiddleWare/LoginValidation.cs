using System.Text;

namespace MossadMVC.LoginMiddleWare
{
    public class LoginValidation
    {
        private readonly RequestDelegate _next;


        public LoginValidation(RequestDelegate next)
        {
            this._next = next;
        }

        //public async Task Invoke(HttpContext context)
        //{

        //    // Headers {Authorization: Bearer ey37729ythkwaw4i}
        //    // Bearer ey37729ythkwaw4i
        //    // [Bearer,ey37729ythkwaw4i]
        //    string BearerToken = context.Request.Headers["Authorization"].FirstOrDefault();
        //    string Token = BearerToken.Split(" ").Last();

        //    if (Token != null)
        //    {
        //        var tokenHandler = new LoginMW();
        //        var key = Encoding.ASCII.GetBytes("123rfy5gejh6fcyt4yg5rhfgu6y5tgrfg5y4rvsdcrevsdgtvh4dgyth4gdrhy4hgdhf5yh45678");
        //        try
        //        {
        //            tokenHandler.InvokeAsync(Token, new LoginMW
        //            {
        //            //    ValidateIssuerSigningKey = true,
        //            //    IssuerSigningKey = new SymmetricSecurityKey(key),
        //            //    ValidateIssuer = false,
        //            //    ValidateAudience = false,
        //            //    ClockSkew = TimeSpan.Zero
        //            //}, out SecurityToken validatedToken);

        //            //var jwtToken = (JwtSecurityToken)validatedToken;

        //            //if (jwtToken.ValidTo < DateTime.UtcNow)
        //            //{
        //            //    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        //            //    await context.Response.WriteAsync("Token has expired");
        //            //    return;
        //            //}
        //        //}
        //        catch
        //        {
        //            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        //            await context.Response.WriteAsync("Invalid Token");
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        //        await context.Response.WriteAsync("Unauthorized - Token is missing");
        //        return;
        //    }
        //    await _next(context);


        }
    }

