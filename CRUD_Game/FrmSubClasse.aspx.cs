using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Game
{
    public partial class FrmSubClasse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Classe> classes = ClasseDAO.ListarClasses();
                PreencherDDLClasse(classes);
            }
            
        }

        private void PreencherDDLClasse(List<Classe> classes)
        {
            DDLClasse.DataSource = classes;
            DDLClasse.DataTextField = "Descricao";
            DDLClasse.DataValueField = "IdClasse";
            DDLClasse.DataBind();
            DDLClasse.Items.Insert(0, "Selecione...");
            
        }

     
        protected void btnConfirmar_Click1(object sender, EventArgs e)
        {
            var descricao = txtDescrição.Text;

            int index = DDLClasse.SelectedIndex;

            if(index == 0)
            {
                lblMensagem.InnerText = "Você precisa selecionar uma classe!";
            }

            else if (descricao != "")
            {
                //Criando uma instância da classe
                Subclasse novasubclasse = new Subclasse();

                //capturando o id da classe dessa subclasse
                int idClasse = Convert.ToInt32(DDLClasse.SelectedValue);
                novasubclasse.ClasseID = idClasse;

                //preencher o objeto
                novasubclasse.Descricao = descricao;

                string mensagem = SubClasseDAO.CadastrarSubClasse(novasubclasse);

                //Limpando campo
                txtDescrição.Text = "";

                lblMensagem.InnerText = mensagem;
            }
        }
    }
}