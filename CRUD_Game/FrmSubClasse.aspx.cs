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
    }
}