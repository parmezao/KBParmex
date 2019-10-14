using JDKB.Data;
using JDKB.Data.EF;
using JDKB.Data.EF.Repositories;
using JDKB.Domain.Contracts;
using JDKB.Domain.Contracts.Data;
using JDKB.Domain.Contracts.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JDKB.DI
{
    public static class Configure
    {
        public static void AddDI(this IServiceCollection services)
        {
            services.AddScoped<JDDataContext>();
            services.AddScoped<ICustomAppSettings, CustomAppSettings>();

            services.AddTransient<IUnityOfWork, UnityOfWork>();
            services.AddTransient<IAppVersionService, AppVersionService>();
            services.AddTransient<INPC_SituacaoRepository, NPC_SituacaoRepositoryEF>();
            services.AddTransient<INPC_ErroRepository, NPC_ErroRepositoryEF>();
            services.AddTransient<ISOL_DeptoRepository, SOL_DeptoRepositoryEF>();
            services.AddTransient<ITipoVisualizacaoRepository, TipoVisualizacaoRepositoryEF>();
            services.AddTransient<ISituacaoBaseRepository, SituacaoBaseRepositoryEF>();
            services.AddTransient<IBaseConhecimentoRepository, BaseConhecimentoRepositoryEF>();
            services.AddTransient<ICausaRaizRepository, CausaRaizRepositoryEF>();
            services.AddTransient<IResumoRepository, ResumoRepositoryEF>();
            services.AddTransient<ISolucaoPaliativaRepository, SolucaoPaliativaRepositoryEF>();
            services.AddTransient<IProdutoRepository, ProdutoRepositoryEF>();
            services.AddTransient<IBaseProdutoRepository, BaseProdutoRepositoryEF>();
            services.AddTransient<IPalavraChaveRepository, PalavraChaveRepositoryEF>();
            services.AddTransient<IBuscaChaveRepository, BuscaChaveRepositoryEF>();
            services.AddTransient<IUsuarioRepository, UsuarioRepositoryEF>();
            services.AddTransient<ISituacaoUsuarioRepository, SituacaoUsuarioRepositoryEF>();
            services.AddTransient<IAnexoRepository, AnexoRepositoryEF>();
        }
    }
}
