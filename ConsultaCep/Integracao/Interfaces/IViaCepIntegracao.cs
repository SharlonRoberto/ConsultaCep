using ConsultaCep.Integracao.Response;

namespace ConsultaCep.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(String cep);
    }
}
