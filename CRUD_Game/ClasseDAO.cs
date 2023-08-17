using System;

namespace CRUD_Game
{
    public class ClasseDAO
    {
        public static string CadastrarClasse(Classe novaclasse)
        {
            string mensagem = "";
            //tratamento de erros
            try
            {
                using (RPG_BDEntities ctx = new RPG_BDEntities())
                {
                    //Cadastrando a nova classe
                    ctx.Classes.Add(novaclasse);
                    //Salvando as alterações mo BD
                    ctx.SaveChanges();
                    mensagem = "Classse cadastrada com sucesso!";
                }
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }

            return mensagem;
        }
    }
}