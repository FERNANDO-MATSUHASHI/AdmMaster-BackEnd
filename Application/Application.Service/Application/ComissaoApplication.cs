using Application.Service.Interface;
using Domain.Service.Interfaces;
using Domain.ViewModel;

namespace Application.Service.Application
{
    public class ComissaoApplication : IComissaoApplication
    {
        private readonly IComissaoService _comissaoService;
        private readonly IUsuarioService _usuarioService;
        private readonly IAtendimentoService _atendimentoService;

        public ComissaoApplication(IComissaoService comissaoService, IUsuarioService usuarioService, IAtendimentoService atendimentoService)
        {
            _comissaoService = comissaoService;
            _usuarioService = usuarioService;
            _atendimentoService = atendimentoService;
        }

        public ComissaoReturnViewModel GetComissao(ComissaoViewModel comissaoViewModel)
        {
            var usuario = _usuarioService.GetUsuarioById(comissaoViewModel.usuarioId);
            var atendimentos = _atendimentoService.GetAtendimentoByBetweenDate(comissaoViewModel.dataInicial, comissaoViewModel.dataFinal);

            var comissao = _comissaoService.GetComissao(usuario, atendimentos);

            return comissao;
        }
    }
}
