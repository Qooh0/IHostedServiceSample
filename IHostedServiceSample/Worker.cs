using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHostedServiceSample
{
    internal class Worker : IHostedService
    {
        public Worker()
        {
            Console.WriteLine("Worker created");
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Worker started");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Worker stopped");
            return Task.CompletedTask;
        }
    }
}
