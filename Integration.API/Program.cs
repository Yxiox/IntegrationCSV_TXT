using System.Data;
using Integration.API.Entities;
using MySql.Data.MySqlClient;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Scan(c =>
    c.FromAssemblies([typeof(Program).Assembly, typeof(CATEGORIA).Assembly])
        .AddClasses(false)
        .AsMatchingInterface()
        .AsImplementedInterfaces()
        .WithTransientLifetime()
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
