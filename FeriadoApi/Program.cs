using FeriadoApi.Context;
using FeriadoApi.Repository;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FeriadoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IFeriadoRepository, FeriadoRepository>();
//builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
//                builder =>
//                {
//                    builder.AllowAnyHeader()
//                           .AllowAnyMethod()
//                           .SetIsOriginAllowed((host) => true)
//                           .AllowCredentials()
//                           .AllowAnyOrigin()
//                           .AllowAnyMethod()
//                           .AllowAnyHeader();
//                }));

#region [Cors]
builder.Services.AddCors();
#endregion
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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

app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
