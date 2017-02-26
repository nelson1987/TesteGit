﻿using System.Collections.Generic;
using System.Linq;

namespace WebForLink.Domain.Entities
{
    public class Aplicacao
    {
        private Aplicacao()
        {
            Usuarios = new List<Usuario>();
            Perfis = new List<Perfil>();
        }

        public Aplicacao(string nome, string descricao)
            : this()
        {
            Nome = nome;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public List<Usuario> Usuarios { get; private set; }
        public List<Perfil> Perfis { get; private set; }

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void AdicionarPerfil(Perfil perfil)
        {
            Perfis.Add(perfil);
        }

        public bool TemEssePerfil(Perfil perfil)
        {
            return Perfis.Any(x => x == perfil);
        }
    }
}