﻿using Servicios.api.Libreria.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Servicios.api.Libreria.Repository
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        Task<IEnumerable<TDocument>> GetAll();
        Task<TDocument> GetById(string id);
        Task InsertDocument(TDocument document);
        Task UpdateDoc(TDocument document);
        Task DeleteDocument(string id);

        Task<PaginationEntity<TDocument>> PaginationBy(
            Expression<Func<TDocument, bool>> filterExpression, 
            PaginationEntity<TDocument> pagination
            );

        Task<PaginationEntity<TDocument>> PaginationByFilter(PaginationEntity<TDocument> pagination);
    }
}
