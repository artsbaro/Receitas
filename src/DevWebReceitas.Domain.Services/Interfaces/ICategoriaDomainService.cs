﻿using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DevWebReceitas.Domain.Services.Interfaces
{
    public interface ICategoriaDomainService : IDomainService<Categoria, Guid>
    {
        void Create(Categoria entity);
        void Update(Categoria entity);
        void Remove(Guid codigo);
        IEnumerable<Categoria> List(CategoriaFilter filter);
    }
}
