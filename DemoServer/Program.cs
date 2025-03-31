var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.AddGraphQL().AddTypes().AddInstrumentation();

var app = builder.Build();

app.MapDefaultEndpoints();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
