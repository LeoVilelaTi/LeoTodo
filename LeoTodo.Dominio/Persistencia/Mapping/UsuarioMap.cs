﻿using LeoTodo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoTodo.Dominio.Persistencia.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            //Primay Key
            HasKey(t => t.Id);

            ToTable("Usuarios");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Identificador).HasColumnName("Identificador");
            Property(t => t.Nome).HasColumnName("Nome");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Senha).HasColumnName("Senha");
            Property(t => t.GuidUsuarioAtivo).HasColumnName("GuidUsuarioAtivo");
            Property(t => t.DataInclusao).HasColumnName("DataInclusao");
            Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
        }
    }
}