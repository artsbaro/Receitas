using DevWebReceitas.Domain.Entities;
using DevWebReceitas.Domain.Filters;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Transactions;

namespace DevWebReceitas.Domain.Services
{
    public class ReceitaDomainService : IReceitaDomainService
    {
        private readonly IReceitaRepository _receitaRepository;
        public static IHostingEnvironment _environment;

        public ReceitaDomainService(IReceitaRepository receitaRepository
            , IHostingEnvironment environment
            )
        {
            _receitaRepository = receitaRepository;
            _environment = environment;
        }

        public void Create(Receita entity)
        {
            using (var trans = new TransactionScope())
            {
                if (entity.HasImage)
                {
                    var path = _environment.WebRootPath + "\\Upload\\";

                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    using (Stream file = File.OpenWrite(path + entity.NomeArquivo))
                    {
                        file.Write(entity.Imagem, 0, entity.Imagem.Length);
                        file.Flush();
                    }

                    entity.CaminhoImagem = path;
                }
                _receitaRepository.Create(entity);
                trans.Complete();
            }
        }

        public Receita FindById(int id)
        {
            var receita = _receitaRepository.FindById(id);
            return receita;
        }

        public Receita FindByCode(Guid code)
        {
            var receita = _receitaRepository.FindByCode(code);
            if (receita == null)
                throw new ArgumentException("Receita não encontrada");

            return receita;
        }

        public byte[] FindImageByCode(Guid codigo)
        {
            var receita = FindByCode(codigo);
            if (receita == null)
                throw new ArgumentException("Receita não encontrada");

            if (File.Exists(receita.CaminhoImagem))
                return File.ReadAllBytes(receita.CaminhoImagem);

            throw new ArgumentException("Arquivo não encontrado");
        }

        public IEnumerable<Receita> List(ReceitaFilter filter)
        {
            return _receitaRepository.List(filter);
        }

        public void Remove(int id)
        {
            _receitaRepository.Remove(id);
        }

        public void Remove(Guid codigo)
        {
            _receitaRepository.Remove(codigo);
        }

        public void Update(Receita entity)
        {
            entity.DataUltimaAlteracao = DateTime.Now;
            using (var trans = new TransactionScope())
            {
                _receitaRepository.Update(entity);
                trans.Complete();
            }
        }
    }
}

