using System;

namespace CRUD_Game
{
    internal class SubClasseDAO
    {
        internal static string CadastrarSubClasse(Subclasse novasubclasse)
        {
            string mensagem = "";
            //tratamento de erros
            try
            {
                using (var ctx = new RPG_BDEntities())
                {
                    
                    //Cadastrando a nova classe
                    ctx.Subclasses.Add(novasubclasse);
                    //Salvando as alterações mo BD
                    ctx.SaveChanges();
                }
                mensagem = "SubClasse " + novasubclasse.Descricao + " cadastrada com sucesso!";
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }

            return mensagem;
        }
    }
}