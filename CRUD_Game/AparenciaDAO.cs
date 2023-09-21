
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_Game
{
    internal class AparenciaDAO
    {
        internal static List<Aparencia> ListarAparencias()
        {
            List<Aparencia> aparencia = null;
            try
            {
                using (var ctx = new RPG_BDEntities())
                {
                    aparencia = ctx.Aparencias.OrderBy(
                        x => x.IdAparencia).ToList();
                }
            }
            catch (Exception ex)
            {
            }
            return aparencia;
        }
    }
}