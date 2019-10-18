using JDKB.Data.EF;
using JDKB.Domain.Entities;
using JDKB.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
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
            var Colunas = new List<EstruturaCampo>
            {
                new EstruturaCampo
                {
                    Nome = "Nome",
                    Tipo = typeof(string),
                    Tamanho = 50
                },
                new EstruturaCampo
                {
                    Nome = "Telefone",
                    Tipo = typeof(string),
                    Tamanho = 20
                },
                new EstruturaCampo
                {
                    Nome = "Idade",
                    Tipo = typeof(long)
                },
                new EstruturaCampo
                {
                    Nome = "Endereco",
                    Tipo = typeof(string),
                    Tamanho = 15
                }
            };

            List<DataColumn> Retorno = Colunas
                .Select(x => new DataColumn(x.Nome, x.Tipo) { MaxLength = x.Tipo == typeof(string) ? x.Tamanho : -1 }).ToList();

          
            foreach (var item in Retorno)
            {
                Console.WriteLine(item.ColumnName);
            }

            Console.ReadKey();

            //foreach (int i in Integers())
            //{
            //    Console.WriteLine(i.ToString());
            //}

            //Console.WriteLine($"Data: {StatusEnum.Active.ToString()}");

            //Console.ReadKey();

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

            //var anx = new Anexo
            //{
            //    Id = 1,
            //    NomeArquivo = "parmex.jpg"
            //};

            //string path = @"C:\Pessoal\parmex.jpg";
            //using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None))
            //{
            //    byte[] bytes = new byte[fs.Length];

            //    using (var ms = new MemoryStream(bytes))
            //    {
            //        fs.CopyToAsync(ms);
            //        ms.Seek(0, SeekOrigin.Begin);

            //        anx.Arquivo = ms.ToArray();
            //    };
            //}

            using (var db = new JDDataContext(connectionString))
            {
                //db.ChangeTracker.LazyLoadingEnabled = false;

                // Persistência [TBJKB_BASE_CONHECIMENTO]
                //db.BaseConhecimento.Add(bc);
                //db.SaveChanges();

                //db.Anexo.Add(anx);
                //db.SaveChanges();

                // Consulta 
                //db.ChangeTracker.LazyLoadingEnabled = false;

                //var _db = db.Set<BaseConhecimento>();
                //var _db = db.Set<Usuario>();
                var _db = db.Set<Anexo>();

                var anexos = _db.ToList();

                foreach (var item in anexos)
                {
                    Console.WriteLine(item.NomeArquivo);

                    // Cria um novo arquivo à partir de um Memorystream, após carregar da base de dados
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(item.Arquivo, 0, item.Arquivo.Length);
                        ms.Seek(0, SeekOrigin.Begin);

                        var path = @"c:\pessoal\parmex3.jpg";
                        using (var fs = new FileStream(path, FileMode.Create))
                        {
                            ms.CopyTo(fs);
                            fs.Flush();
                        }
                    }

                    // Cria um novo arquivo carregando diretamente da base de dados
                    File.WriteAllBytes(@"c:\pessoal\parmex2.jpg", item.Arquivo.ToArray());
                }


                //var bc = _db.Skip(0).Take(10).ToList();

                //foreach (var item in bc)
                //{
                //    Console.WriteLine(item.Id.ToString());
                //}

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
