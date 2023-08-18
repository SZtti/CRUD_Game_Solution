using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Game
{
    public partial class FrmRaca : System.Web.UI.Page
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
                Raca novaraca = new Raca();

                //preencher o objeto
                novaraca.Descricao = descricao;

                string mensagem = RacaDAO.CadastrarRaca(novaraca);

                //Limpando campo
                txtDescrição.Text = "";

                lblMensagem.InnerText = mensagem;
            }
        }
    }
}