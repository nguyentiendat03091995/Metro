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
    
    public partial class CA_HOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_HOC()
        {
            this.THOIKHOABIEUx = new HashSet<THOIKHOABIEU>();
        }
    
        public string MACH { get; set; }
        public string TENCA { get; set; }
        public int SOTIET { get; set; }
        public double THOIGIAN1TIET { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THOIKHOABIEU> THOIKHOABIEUx { get; set; }
    }
}
