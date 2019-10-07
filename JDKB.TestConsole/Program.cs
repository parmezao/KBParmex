using JDKB.Data.EF;
using JDKB.Domain.Entities;
using JDKB.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace JDKB.TestConsole
{
    class Program
    {
        public enum StatusEnum
        {
            Active, Deactive
        }

        public static IEnumerable<int> Integers()
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield return 16;
            yield return 16777216;
        }

        static void Main(string[] args)
        {

            foreach (int i in Integers())
            {
                Console.WriteLine(i.ToString());
            }

            //Console.WriteLine($"Data: {StatusEnum.Active.ToString()}");
           
            Console.ReadKey();

            //return;

            string connectionString = @"Server=JDSP103;Database=JDSOL_SOLICITACAO;Trusted_Connection=True;MultipleActiveResultSets=true";


            //var bc = new BaseConhecimento
            //{
            //    DtHrRegistro = 20190905114200,
            //    //MatRegistro = "162",
            //    TpVisualizacao = "INTERNO",
            //    StBase = "ATV"
            //};

            ///// Causa Raiz
            //bc.CausaRaiz.Add(
            //    new CausaRaiz
            //    {
            //        SeqVersao = 1,
            //        DtHrRegistro = 20190905114200,
            //        //MatRegistro = "162",
            //        TpVisualizacao = "INTERNO",
            //        Texto = "Testando Causa Raiz 1"
            //    }
            //);
            //bc.CausaRaiz.Add(
            //    new CausaRaiz
            //    {
            //        SeqVersao = 2,
            //        DtHrRegistro = 20190905114200,
            //        //MatRegistro = "162",
            //        TpVisualizacao = "INTERNO",
            //        Texto = "Testando Causa Raiz 2"
            //    }
            //);

            ///// Resumo
            //bc.Resumo.Add(
            //    new Resumo
            //    {
            //        SeqVersao = 1,
            //        DtHrRegistro = 20190905114200,
            //        //MatRegistro = "162",
            //        TpVisualizacao = "INTERNO",
            //        DsTitulo = "Titulo 1",
            //        Texto = "Testando Resumo 1"
            //    }
            //);
            //bc.Resumo.Add(
            //    new Resumo
            //    {
            //        SeqVersao = 2,
            //        DtHrRegistro = 20190905114200,
            //        //MatRegistro = "162",
            //        TpVisualizacao = "INTERNO",
            //        DsTitulo = "Titulo 2",
            //        Texto = "Testando Resumo 2"
            //    }
            //);

            ///// Solução Paliativa
            //bc.SolucaoPaliativa.Add(
            //    new SolucaoPaliativa
            //    {
            //        SeqVersao = 1,
            //        DtHrRegistro = 20190905114200,
            //        //MatRegistro = "162",
            //        TpVisualizacao = "INTERNO",
            //        Texto = "Testando Solucao Paliativa 1"
            //    }
            //);
            //bc.SolucaoPaliativa.Add(
            //    new SolucaoPaliativa
            //    {
            //        SeqVersao = 2,
            //        DtHrRegistro = 20190905114200,
            //        //MatRegistro = "162",
            //        TpVisualizacao = "INTERNO",
            //        Texto = "Testando Solucao Paliativa 2"
            //    }
            //);

            ///// Produto
            //bc.Produto.Add(
            //    new Produto
            //    {
            //        CodEvento = "12",
            //        DtHrRegistro = 20190905114200,
            //        MatRegistro = "162"
            //    }
            //);

            using (var db = new JDDataContext(connectionString))
            {
                //db.ChangeTracker.LazyLoadingEnabled = false;

                // Persistência [TBJKB_BASE_CONHECIMENTO]
                //db.BaseConhecimento.Add(bc);
                //db.SaveChanges();

                // Consulta 
                //db.ChangeTracker.LazyLoadingEnabled = false;

                var _db = db.Set<BaseConhecimento>();
                //var _db = db.Set<Usuario>();

                var bc = _db.Skip(0).Take(10).ToList();

                foreach (var item in bc)
                {
                    Console.WriteLine(item.Id.ToString());
                }

                //var usuario = _db.Find(Convert.ToDecimal(1));

                //if (usuario != null)
                //{
                //    usuario.HashSenha = "123456".Encrypt();

                //    _db.Update(usuario);
                //    db.SaveChanges();

                //};


                //var lsBaseConhecimento = _db
                //    .Include(r => r.Responsavel)
                //    .Include(c => c.CausaRaiz)
                //    .Include(c => c.Resumo)
                //    .Include(c => c.SolucaoPaliativa)
                //    .Include(c => c.Produto).ThenInclude(e => e.Evento)
                //    .ToList();

                //var lsFiltro = lsBaseConhecimento
                //    .Select(c => new BaseConhecimento()
                //    {
                //        Id = c.Id,
                //        DtHrRegistro = c.DtHrRegistro,
                //        MatRegistro = c.MatRegistro,
                //        TpVisualizacao = c.TpVisualizacao,
                //        StBase = c.StBase,
                //        Responsavel = c.Responsavel,
                //        TipoVisualizacao = c.TipoVisualizacao,
                //        SituacaoBase = c.SituacaoBase,

                //        CausaRaiz = c.CausaRaiz
                //            .Where(d => d.SeqVersao == lsBaseConhecimento.SelectMany(x => x.CausaRaiz)
                //            .Select(i => i.SeqVersao).Max()).ToList(),
                //        Resumo = c.Resumo
                //            .Where(d => d.SeqVersao == lsBaseConhecimento.SelectMany(x => x.Resumo)
                //            .Select(i => i.SeqVersao).Max()).ToList(),
                //        SolucaoPaliativa = c.SolucaoPaliativa
                //            .Where(d => d.SeqVersao == lsBaseConhecimento.SelectMany(x => x.SolucaoPaliativa)
                //            .Select(i => i.SeqVersao).Max()).ToList(),
                //        Produto = c.Produto
                //    });


                //foreach (var s in lsFiltro)
                //{
                //    foreach (var c in s.CausaRaiz)
                //    {
                //        Console.WriteLine($"Resp: {s.Responsavel.Nome} - Causa Raiz: {c.Texto}");
                //    }
                //    foreach (var r in s.Resumo)
                //    {
                //        Console.WriteLine($"Resp: {r.Responsavel.Nome} - Resumo: {r.Texto}");
                //    }
                //    foreach (var r in s.SolucaoPaliativa)
                //    {
                //        Console.WriteLine($"Resp: {r.Responsavel.Nome} - Solução: {r.Texto}");
                //    }
                //    foreach (var p in s.Produto)
                //    {
                //        Console.WriteLine($"Resp: {p.Responsavel.Nome} - Produto: {p.Evento.DescEvento}");
                //    }
                //}
            }

            Console.ReadKey();
        }        
    }
}
