﻿using ProAspNetCoreMvcModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcModelBinding.Repository
{
    public class MemoryRepository : IRepository
    {
        private Dictionary<int, Pessoa> pessoas = new Dictionary<int, Pessoa>
        {
            [1] = new Pessoa
            {
                PessoaId = 1,
                Nome = "Maria",
                Sobrenome = "Rodrigues",
                Permissao = Dominio.Permissao.Admin
            },
            [2] = new Pessoa
            {
                PessoaId = 2,
                Nome = "Leonor",
                Sobrenome = "Nunes",
                Permissao = Dominio.Permissao.Usuario
            },
            [3] = new Pessoa
            {
                PessoaId = 3,
                Nome = "Matilde",
                Sobrenome = "Henriques",
                Permissao = Dominio.Permissao.Usuario
            },
            [4] = new Pessoa
            {
                PessoaId = 4,
                Nome = "Beatriz",
                Sobrenome = "Mendes",
                Permissao = Dominio.Permissao.Convidado
            }
        };
        public IEnumerable<Pessoa> Pessoa => pessoas.Values;
        public Pessoa this[int id]
        {
            get
            {
                return pessoas.ContainsKey(id) ? pessoas[id] : null;
            }
            set
            {
                pessoas[id] = value;
            }
        }
    }
}
