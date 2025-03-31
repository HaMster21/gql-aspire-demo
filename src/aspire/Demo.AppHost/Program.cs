var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DemoServer>("demoserver");

builder.AddProject<Projects.frontend>("frontend");

builder.Build().Run();
