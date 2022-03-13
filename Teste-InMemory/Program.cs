using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Teste_InMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var eventoService = serviceProvider.GetService<IEventoService>();

            Console.WriteLine("Iniciando a aplicação");

            eventoService.GenerateFakeData();
            eventoService.ProcessarFila();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IEventoService, EventoService>()
                .AddScoped<IEventoRepository, EventoRepository>()
                .AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase("teste"));
        }
    }
}
