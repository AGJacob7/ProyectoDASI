//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class CATEGORIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATEGORIA()
        {
            this.PRODUCTO = new List<PRODUCTO>();
        }
    
        public int IDCATEGORIA { get; set; }
        public string NOMCATEGORIA { get; set; }
        public string TIPOCATEGORIA { get; set; }
        public Nullable<short> ACTIVOCATEGORIA { get; set; }
        public Nullable<System.DateTime> FECHAREGISTROCATEGORIA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<PRODUCTO> PRODUCTO { get; set; }
    }
}
