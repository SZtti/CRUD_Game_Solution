﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Game
{
    public partial class Subclasse
    {
        public Classe GetClasse()
        {
            Classe classe = ClasseDAO.ListarClasses(ClasseID);
            return null;
        }
    }
}