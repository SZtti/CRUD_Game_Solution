using System;
using System.Data.SqlClient;

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
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    mensagem = "A habilidade " + novahabilidade.Descricao + " já existe.";
                }
                else
                {
                    mensagem = "Ocorreu um erro: " + ex.Message;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("An error occurred while updating the entries"))
                {
                    mensagem = "A habilidade " + novahabilidade.Descricao + " já existe.";
                }
                else
                {
                    mensagem = "Ocorreu um erro: " + ex.Message;
                }
            }
            
            return mensagem;
        }
    }
}