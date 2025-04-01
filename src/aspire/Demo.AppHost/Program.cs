var builder = DistributedApplication.CreateBuilder(args);

var db = builder
    .AddSqlServer("sql")
    .AddDatabase("library");

var backend = builder
    .AddProject<Projects.DemoServer>("demoserver")
    .WithReference(db)
    .WaitFor(db);

var frontend = builder.AddProject<Projects.frontend>("frontend");

builder.Build().Run();
