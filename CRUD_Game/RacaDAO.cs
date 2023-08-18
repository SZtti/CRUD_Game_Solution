using System;

namespace CRUD_Game
{
    public class RacaDAO
    {
        public static string CadastrarRaca(Raca novaraca)
        {
            string mensagem = "";
            //tratamento de erros
            try
            {
                using (RPG_BDEntities ctx = new RPG_BDEntities())
                {
                    //Cadastrando a nova classe
                    ctx.Racas.Add(novaraca);
                    //Salvando as alterações mo BD
                    ctx.SaveChanges();
                    mensagem = "Raça " + novaraca.Descricao + " cadastrada com sucesso!";
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