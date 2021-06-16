namespace SignalRConsoleClient
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.SignalR.Client;
    using Microsoft.Extensions.DependencyInjection;

    public static class Program
    {
        public static async Task Main()
        {
            Console.ReadLine();

            var connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:5001/coffeehub")                
                .Build();

            connection.On<Order>(
                "NewOrder",
                (order) => Console.WriteLine($"Somebody ordered an {order.Product} ({order.Size})"));

            await connection.StartAsync();

            Console.WriteLine("Listening. Press enter to exit...");
            Console.ReadLine();
        }
    }
}
