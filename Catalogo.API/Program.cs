using Integration.API.Entities;
using Integration.Shared.Config;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Scan(c =>
    c.FromAssemblies(typeof(Program).Assembly, typeof(CATEGORIA).Assembly)
        .AddClasses(false)
        .AsMatchingInterface()
        .AsImplementedInterfaces()
        .WithTransientLifetime()
);

builder.Services.AddIntegration();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.AddIntegration();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
