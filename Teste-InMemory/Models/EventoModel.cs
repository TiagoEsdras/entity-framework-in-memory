﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Teste_InMemory
{
    public class EventoModel
    {
        [Key]
        public int EventoId { get; set; }

        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInclusao { get; set; }
        public bool Avisar { get; set; }
    }
}