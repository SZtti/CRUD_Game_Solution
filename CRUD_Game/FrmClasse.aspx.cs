using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Game
{
    public partial class FrmClasse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PopularLVs();
            }
        }

        private void PopularLVs()
        {
            var classes = ClasseDAO.ListarClasses();
            PopularLVClasses(classes);
        }

        private void PopularLVClasses(List<Classe> classes)
        {
            lvClasses.DataSource = classes;
            lvClasses.DataBind();
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescrição.Text;

            if (descricao != "")
            {
                //Criando uma instância da classe
                Classe novaclasse = new Classe();

                //preencher o objeto
                novaclasse.Descricao = descricao;

                string mensagem = ClasseDAO.CadastrarClasse(novaclasse);

                //Limpando campo
                txtDescrição.Text = "";

                lblMensagem.InnerText = mensagem;

                PopularLVs();
            }
        }


    }
}