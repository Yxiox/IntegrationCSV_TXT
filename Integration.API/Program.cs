using MySql.Data.MySqlClient;
using System.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Scan(c =>
                    c.FromCallingAssembly()
                    .AddClasses(false)
                    .AsMatchingInterface()
                    .AsImplementedInterfaces()
                    .WithTransientLifetime());

builder.Services.AddTransient<IDbConnection>(x => new MySqlConnection(
    "server=localhost;database=apoionegocio;uid=root;pwd=root"
));

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
