﻿using System;
using System.Collections.Generic;

namespace ExampleDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial()
        {
            return this.Ativo && DateTime.Now.Year - this.DataCadastro.Year >= 5;
        }
    }
}
