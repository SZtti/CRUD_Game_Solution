using System;
using System.Collections.Generic;
using System.Linq;

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

        internal static List<Subclasse> ListarSubClasse()
        {
            List<Subclasse> Subclasses = null;
            try
            {
                using (var ctx = new RPG_BDEntities())
                {
                    Subclasses = ctx.Subclasses.OrderBy(x => x.Descricao).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return Subclasses;
        }

        internal static Subclasse Remover(int idSubclasse)
        {
            Subclasse sub = null;

            using(var ctx = new RPG_BDEntities())
            {
                sub = ctx.Subclasses.FirstOrDefault(x => x.IdSubclasse == idSubclasse);
                ctx.Subclasses.Remove(sub);
                ctx.SaveChanges();
            }
            return sub;
        }
    }
    }
