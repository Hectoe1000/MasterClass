
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using UtilitarioAutomapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//JWT IMPLEMENTACIÓN

//JWT IMPLEMENTACIÓN
builder.Services
    .AddHttpContextAccessor()
    .AddAuthorization()
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ClockSkew = TimeSpan.Zero,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });


//builder.Services.AddAuthentication("Bearer").AddJwtBearer(opt =>
//{
//    var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWt:Key"]));
//    var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature);
//    opt.RequireHttpsMetadata = false;
//    opt.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateAudience = false,
//        ValidateIssuer = false,
//        IssuerSigningKey = signingKey
//    };

//});


//JWT





builder.Services.AddEndpointsApiExplorer();

//ESTA LINEA NOS SIRVE PARA CONFIGURAR NUESTRO AUTOMAPPER
builder.Services.AddAutoMapper(typeof(IStartup).Assembly, typeof(AutoMapperProfiles).Assembly);


builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
