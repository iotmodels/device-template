using mqtt_device;
using System.Diagnostics;

//using ConsoleTraceListener consoleListner = new ConsoleTraceListener();
//Trace.Listeners.Add(consoleListner);

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Device>();
    })
    .Build();

await host.RunAsync();
