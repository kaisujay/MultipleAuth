using Microsoft.Owin.Security.OAuth;
using OAuthTest;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions
{
    AllowInsecureHttp = true,
    //The Path For generating the Toekn
    TokenEndpointPath = new PathString("/token"), //Setting the Token Expired Time (24 hours)
    AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
    //MyAuthorizationServerProvider class will validate the user credentials
    Provider = new MyAuthServiceProvider()
};
//Token Generations
app.UseOAuthAuthorizationServer(options);
app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

HttpConfiguration config = new HttpConfiguration();
WebApiConfig.Register(config);


app.UseAuthorization();

app.MapControllers();

app.Run();
