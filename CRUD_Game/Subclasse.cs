//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_Game
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subclasse
    {
        public int IdSubclasse { get; set; }
        public string Descricao { get; set; }
        public int ClasseID { get; set; }
    
        public virtual Classe Classe { get; set; }
    }
}
