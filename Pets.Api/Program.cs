using Pets.Api.Database.DatabaseSettings;
using Pets.Api.Database.Provider;
using Pets.Api.Database.Repository;
using Raven.Client.Documents;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IDatabaseProvider, DatabaseProvider>();
builder.Services.AddSingleton<IDogsRepository, DogsRepository>();

var settings = builder.Configuration.GetSection("RavenDbSettings").Get<RavenDbSettings>();
builder.Services.AddSingleton(settings);
var database = new DatabaseProvider();
database.CreateDatabase();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
