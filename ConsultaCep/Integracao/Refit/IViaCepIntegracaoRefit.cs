using ConsultaCep.Integracao.Response;
using Refit;

namespace ConsultaCep.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(String cep);
    }
}
