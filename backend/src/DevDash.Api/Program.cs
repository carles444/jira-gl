using DevDash.Api.GraphQL;
using DevDash.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<DevDashDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Configuración de GraphQL
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections() // Permite que EF elija solo las columnas necesarias
    .AddFiltering()   // Habilita filtros tipo: { name: { startsWith: "Jira" } }
    .AddSorting()     // Habilita order by dinámico
    .RegisterDbContextFactory<DevDashDbContext>();

var app = builder.Build();

app.MapGraphQL(); // Punto de entrada: /graphql

app.Run();
