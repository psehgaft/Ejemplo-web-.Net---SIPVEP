//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIPVEP.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Provedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Provedor()
        {
            this.Articulo_Provedor = new HashSet<Articulo_Provedor>();
        }
    
        public int Id_provedor { get; set; }
        public string rfc { get; set; }
        public string razon_social { get; set; }
        public string direccion_fiscal { get; set; }
        public string cp_fiscal { get; set; }
        public string ciudad_fiscal { get; set; }
        public string estado_fiscal { get; set; }
        public string nombre_alias { get; set; }
        public string correo_fiscal { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo_contacto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo_Provedor> Articulo_Provedor { get; set; }
    }
}
