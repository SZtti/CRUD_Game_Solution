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
    
    public partial class Personagem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personagem()
        {
            this.Habilidades = new HashSet<Habilidade>();
        }
    
        public int IdPersonagem { get; set; }
        public Nullable<System.DateTime> Data_Nasc { get; set; }
        public int Nivel { get; set; }
        public string Nome_Personagem { get; set; }
        public string Sexo { get; set; }
        public int AparenciaID { get; set; }
        public int AtributoID { get; set; }
        public int RacaID { get; set; }
        public int SubClasseID { get; set; }
        public int ClasseID { get; set; }
    
        public virtual Aparencia Aparencia { get; set; }
        public virtual Atributo Atributo { get; set; }
        public virtual Classe Classe { get; set; }
        public virtual Raca Raca { get; set; }
        public virtual Subclasse Subclasse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}
