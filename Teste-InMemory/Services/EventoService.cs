using System;
using System.Linq;

namespace Teste_InMemory
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository _eventoRepository;

        public EventoService(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public void GenerateFakeData()
        {

            var evento = new EventoModel
            {
                Data = DateTime.Now,
                Descricao = "Descricao de evento",
                DataInclusao = DateTime.Now,
                Avisar = true
            };

            _eventoRepository.Incluir(evento);
        }

        public void ProcessarFila()
        {
            Console.WriteLine("Obtendo a lista:");
            var lista = _eventoRepository.Listar();
            Console.WriteLine("Objetos obtidos " + lista.Count());
            foreach(var evento in lista)
            {
                Console.WriteLine("Novo evento: " + evento.Data.ToString("dd/MM/yyyy") + " Hora: " + evento.Data.ToString("hh:mm"));
            }

            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}