using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var connectionString = builder.Configuration.GetConnectionString("library");
builder.Services.AddDbContextPool<CatalogDbContext>(dbContextOptionsBuilder => dbContextOptionsBuilder.UseSqlServer(connectionString));
builder.EnrichSqlServerDbContext<CatalogDbContext>();

builder.AddGraphQL().AddTypes().AddInstrumentation();

var app = builder.Build();

app.MapDefaultEndpoints();

app.MapGraphQL();

using var scope = app.Services.CreateScope();
//var dbContext = scope.ServiceProvider.GetRequiredService<CatalogDbContext>();
//dbContext.Database.EnsureCreated();
//dbContext.Database.Migrate();

app.RunWithGraphQLCommands(args);
