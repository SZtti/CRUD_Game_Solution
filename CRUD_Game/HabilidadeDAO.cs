using System;

namespace CRUD_Game
{
    internal class HabilidadeDAO
    {
        internal static string CadastrarHabilidade(Habilidade novahabilidade)
        {
            string mensagem = "";
            //tratamento de erros
            try
            {
                using (var ctx = new RPG_BDEntities())
                {
                    //Cadastrando a nova classe
                    ctx.Habilidades.Add(novahabilidade);
                    //Salvando as alterações mo BD
                    ctx.SaveChanges();
                }
                mensagem = "Habilidade " + novahabilidade.Descricao + " cadastrada com sucesso!";
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }

            return mensagem;
        }
    }
}