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
    
    public partial class Atributo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Atributo()
        {
            this.Personagems = new HashSet<Personagem>();
        }
    
        public int IdAtributo { get; set; }
        public int Força { get; set; }
        public int Destreza { get; set; }
        public int Sabedoria { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Carisma { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personagem> Personagems { get; set; }
    }
}
