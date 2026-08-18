using SenacQuizApp.banco.repositories;
using SenacQuizApp.Banco.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Services
{
    public class PerguntaService
    {
        private readonly PerguntaRepository _perguntaRepository;

        public PerguntaService(PerguntaRepository perguntaRepository)
        {
            _perguntaRepository = perguntaRepository;
        }
        public async Task CriarPerguntaTema()
        {

        }

        public async Task CriarPergunta()
        {

        }
    }
}
