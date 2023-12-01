using AspireWithNextJS.AppHost;

var builder = DistributedApplication.CreateBuilder(args);

var webapi = builder.AddProject<Projects.AspireWithNextjs_WebAPI>("aspirewithnextjs.webapi");

builder.AddNpmApp("frontend-nextjs", "../nextjs-aspire-demo", "dev")
    .WithReference(webapi)
    .WithServiceBinding(scheme: "http");

builder.Build().Run();
