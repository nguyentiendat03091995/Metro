//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoMetroUI.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class NGANH_HOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGANH_HOC()
        {
            this.NH_MH = new HashSet<NH_MH>();
        }
    
        public string MANGANH { get; set; }
        public string TENNGANH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_MH> NH_MH { get; set; }
    }
}
