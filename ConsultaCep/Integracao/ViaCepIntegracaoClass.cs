using ConsultaCep.Integracao.Interfaces;
using ConsultaCep.Integracao.Refit;
using ConsultaCep.Integracao.Response;

namespace ConsultaCep.Integracao
{
    public class ViaCepIntegracaoClass : IViaCepIntegracao
    {
        private readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;


        public ViaCepIntegracao(IViaCepIntegracaoRefit viaCepIntegracaoRefit)
        {
            _viaCepIntegracaoRefit = viaCepIntegracaoRefit;
        }

        public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
        {
            var responseData = await _viaCepIntegracaoRefit.ObterDadosViaCep(cep);

            if (responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }

            return null;

        }
    }
}
