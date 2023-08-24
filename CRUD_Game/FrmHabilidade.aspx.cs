using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Game
{
    public partial class FrmHabilidade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            var descricao = txtDescrição.Text;

            if (descricao != "")
            {
                //Criando uma instância da classe
                Habilidade novahabilidade = new Habilidade();

                //preencher o objeto
                novahabilidade.Descricao = descricao;

                string mensagem = HabilidadeDAO.CadastrarHabilidade(novahabilidade);

                //Limpando campo
                txtDescrição.Text = "";

                lblMensagem.InnerText = mensagem;
            }
        }
    }
}