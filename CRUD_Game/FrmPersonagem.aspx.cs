using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Game
{
    public partial class FrmPersonagm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopularDDls();
        }

        private void PopularDDls()
        {
            try
            {
                List<Raca> racas = RacaDAO.ListarRacas();
                List<Subclasse> subclasses = SubClasseDAO.ListarSubClasse();
                List<Aparencia> aparencias = AparenciaDAO.ListarAparencia();
                List<Atributo> atributos = AtributoDAO.ListarAtributo();

              
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}