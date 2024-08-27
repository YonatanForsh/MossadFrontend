namespace MossadMVC.LoginMiddleWare
{
    public class LoginMW
    {
        private readonly RequestDelegate _next;
        public LoginMW(RequestDelegate next)
        {
            this._next = next;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            var request = context.Request;
            Console.WriteLine($"Inside LogginMiddleWare");
            await this._next(context);
        }
    }
}
