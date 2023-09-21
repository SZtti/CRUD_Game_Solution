using System;
using System.Collections.Generic;
using System.Linq;

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
                    mensagem = "Classe " + novaclasse.Descricao + " cadastrada com sucesso!";
                }
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }

            return mensagem;
        }

        internal static Classe ListarClasses(int classeID)
        {
            Classe classe = null;

            using (var ctx = new RPG_BDEntities())
            {
                classe = ctx.Classes.FirstOrDefault(
                    x => x.IdClasse == classeID
                    ) ;
            }

            return classe;
        }

        internal static List<Classe> ListarClasses()
        {
            List<Classe> classes = null;
            try
            {
                using (var ctx = new RPG_BDEntities())
                {
                    classes = ctx.Classes.OrderBy(x => x.Descricao).ToList();
                }
            }
            catch (Exception ex)
            {
                
            }
            return classes;
        }
    }
}