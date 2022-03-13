using System.Collections.Generic;

namespace Teste_InMemory
{
    public interface IEventoRepository
    {
        public EventoModel Incluir(EventoModel obj);

        public EventoModel ALterar(EventoModel obj);

        public bool Excluir(int id);

        public IEnumerable<EventoModel> Listar();

        public EventoModel Obter(int id);
    }
}