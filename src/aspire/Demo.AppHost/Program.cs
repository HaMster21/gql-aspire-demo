var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DemoServer>("demoserver");

builder.Build().Run();
