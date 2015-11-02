﻿using LeoTodo.Dominio.Entidade;
using LeoTodo.Dominio.Repositorios;
using System;
using System.Collections.Generic;

namespace LeoTodo.Dominio.Servico
{
    public class TarefaDomainService
    {
        TarefaRepositorioLeitura repositorioLeitura = new TarefaRepositorioLeitura();
        TarefaRepositorioEscrita repositorioEscrita = new TarefaRepositorioEscrita();


        public Tarefa ConsultarPorId(int id)
        {
            var retorno = repositorioLeitura.ConsultarPorId(id);

            return retorno;
        }

        public IEnumerable<Tarefa> ConsultarTodas()
        {
            var retorno = repositorioLeitura.ConsultarTodas();

            return retorno;
        }

        public Tarefa Incluir(Tarefa tarefa)
        {
            var tarefaNova = repositorioEscrita.Inserir(tarefa);

            return tarefaNova;
        }

        public void Alterar(Tarefa tarefa)
        {
            repositorioEscrita.Alterar(tarefa);
        }

        public void Deletar(int id)
        {
            var tarefaBanco = repositorioLeitura.ConsultarPorId(id);
            repositorioEscrita.Deletar(tarefaBanco);
        }
    }
}
