﻿using System;

namespace ToroChallenge.PapelContexto.Domain.Queries.Responses
{
    public class BuscaAtivosNegociadosResponse
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public double PrecoAtual { get; set; }
    }
}
