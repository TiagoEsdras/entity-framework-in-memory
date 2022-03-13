using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste_InMemory
{
    public class EventoRepository : IEventoRepository
    {
        private readonly DatabaseContext _databaseContext;

        public EventoRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public EventoModel ALterar(EventoModel obj)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public EventoModel Incluir(EventoModel obj)
        {
            _databaseContext.Add(obj);
            _databaseContext.SaveChanges();
            return obj;
        }

        public IEnumerable<EventoModel> Listar()
        {
            return _databaseContext.Eventos.ToList();
        }

        public EventoModel Obter(int id)
        {
            return _databaseContext.Eventos.Where(a => a.EventoId == id).FirstOrDefault();
        }
    }
}