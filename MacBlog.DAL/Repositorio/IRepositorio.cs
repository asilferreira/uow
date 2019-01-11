﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MacBlog.DAL.Repositorio
{
    public interface IRepositorio<T> where T : class
    {
        IEnumerable<T> GetTudo(Expression<Func<T, bool>> predicate = null);
        T Get(Expression<Func<T, bool>> predicate);
        void Adicionar(T entity);
        void Atualizar(T entity);
        void Deletar(T entity);
        int Contar();
    }
}
