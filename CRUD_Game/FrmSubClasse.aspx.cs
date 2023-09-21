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
                PopularLVs();
            }

            
        }

        private void PopularLVs()
        {
            var subclasses = SubClasseDAO.ListarSubClasse();
            lvSubClasses.DataSource = subclasses;
            lvSubClasses.DataBind();
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
                PopularLVs();
            }
        }
        

        protected void lvSubClasses_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if(e.CommandName == "Excluir"){
                var id = e.CommandArgument;
                if(id != null)
                {
                    int idSubclasse = Convert.ToInt32(id);
                    Subclasse subExcluida = SubClasseDAO.Remover(idSubclasse);
                    if(subExcluida != null)
                    {
                        lblMensagem.InnerText = "Subclasse " + subExcluida.Descricao + " excluida com sucesso!";
                        PopularLVs();
                    }
                }
            }
        }
    }
}