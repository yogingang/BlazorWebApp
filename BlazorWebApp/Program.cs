//using BlazorWebApp.Behaviors;
//using BlazorWebApp.Data;
//using BlazorWebApp.Helper;
//using BlazorWebApp.Injectables;
//using MediatR;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Components.Web;
//using Serilog;

//var configuration = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json", false, true)
//    .AddJsonFile($"appsettings.Development.json", optional: true)
//    .Build();

//Log.Logger = new LoggerConfiguration()
//    .ReadFrom.Configuration(configuration)
//    .CreateBootstrapLogger();

//try
//{
//    var builder = WebApplication.CreateBuilder(args);

//    builder.Host.UseSerilog((context, configuration) => configuration
//                                    .ReadFrom
//                                    .Configuration(context.Configuration));

//    // Add services to the container.
//    builder.Services.AddRazorPages();
//    builder.Services.AddServerSideBlazor();
//    builder.Services.AddMediatR(AssemblyHelper.GetAllAssemblies().ToArray());
//    //builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(MediatRLoggingBehavior<,>));

//    builder.Services.Scan(scan => scan
//                            .FromAssemblies(AssemblyHelper.GetAllAssemblies())
//                            .AddClasses(classes => classes.AssignableTo<ITransientService>())
//                            .AsImplementedInterfaces()
//                            .WithTransientLifetime()
//                            .AddClasses(classes => classes.AssignableTo<IScopedService>())
//                            .AsImplementedInterfaces()
//                            .WithScopedLifetime()
//                            .AddClasses(classes => classes.AssignableTo<ISingletonService>())
//                            .AsImplementedInterfaces()
//                            .WithSingletonLifetime()
//                            );

//    var app = builder.Build();

//    // Configure the HTTP request pipeline.
//    if (!app.Environment.IsDevelopment())
//    {
//        app.UseExceptionHandler("/Error");
//        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//        app.UseHsts();
//    }

//    app.UseHttpsRedirection();

//    app.UseStaticFiles();

//    app.UseRouting();

//    app.MapBlazorHub();
//    app.MapFallbackToPage("/_Host");

//    app.Run();
//}
//catch (Exception ex)
//{
//    string type = ex.GetType().Name;
//    if (type.Equals("StopTheHostException", StringComparison.OrdinalIgnoreCase)) throw;
//    Log.Fatal(ex, "Host terminated unexpectedly");
//}
//finally
//{
//    Log.CloseAndFlush();
//}
