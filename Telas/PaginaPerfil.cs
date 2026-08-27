using AntdUI;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Enums;
using SenacQuizApp.Modelos;
using SenacQuizApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas
{
    public partial class PaginaPerfil : UserControl
    {
        private readonly int _usuarioId;
        private readonly UsuarioPerfilService _usuarioPerfilService;

        public event Action<int>? AbrirConquistas;

        public PaginaPerfil(int usuarioId, UsuarioPerfilService usuarioPerfilService)
        {
            _usuarioId = usuarioId;
            _usuarioPerfilService = usuarioPerfilService;

            InitializeComponent();
        }

        private async void PaginaPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                UsuarioPerfilDto? perfil = await _usuarioPerfilService.ObterPerfilPorId(_usuarioId);

                if (perfil == null)
                {
                    return;
                }

                AtualizarPerfil(perfil);

            }
            catch
            {

            }
        }

        private void AtualizarPerfil(UsuarioPerfilDto perfil)
        {
            LabelUsuario.Text = perfil.Nickname;
            LabelNivel.Text = perfil.Nivel;

            int pontosAtuais = perfil.PontuacaoTotal;
            int pontosMinimosNivelAtual = 0;
            int pontosMaximosProximoNivel = 0;

            switch (perfil.NivelId)
            {
                case UsuarioNivelId.Iniciante:
                    pontosMinimosNivelAtual = 0;
                    pontosMaximosProximoNivel = 500;
                    break;
                case UsuarioNivelId.Aprendiz:
                    pontosMinimosNivelAtual = 501;
                    pontosMaximosProximoNivel = 2000;
                    break;
                case UsuarioNivelId.Intermediario:
                    pontosMinimosNivelAtual = 20001;
                    pontosMaximosProximoNivel = 10000;
                    break;
                case UsuarioNivelId.Avancado:
                    ProgressUsuarioNivel.Value = 1F;
                    ProgressUsuarioNivel.Text = "Nível Máximo";
                    return;
            }

            int progressoNivel = pontosAtuais - pontosMinimosNivelAtual;
            int totalNecessarioNoNivel = pontosMaximosProximoNivel - pontosMinimosNivelAtual;

            if (progressoNivel < 0) progressoNivel = 0;

            ProgressUsuarioNivel.Value = (float)progressoNivel / totalNecessarioNoNivel;


            LabelProgressoPontos.Text = $"% {pontosAtuais} / {pontosMaximosProximoNivel} Pontos";

            LabelInsertPontuacaoTotal.Text = perfil.PontuacaoTotal.ToString();
            LabelInsertAcertos.Text = perfil.TotalAcertos.ToString();
            LabelInsertTotalRespostas.Text = perfil.TotalRespondidos.ToString();
            if (perfil.TotalAcertos == 0 || perfil.TotalRespondidos == 0) { LabelInsertTaxaAcertos.Text = "0%"; }
            else
            {
                LabelInsertTaxaAcertos.Text = $"{(double)perfil.TotalAcertos / perfil.TotalRespondidos:P0}";
            }
        }
    }
}
