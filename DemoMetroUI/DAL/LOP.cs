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
    
    public partial class LOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP()
        {
            this.SINH_VIEN = new HashSet<SINH_VIEN>();
            this.THOIKHOABIEUx = new HashSet<THOIKHOABIEU>();
        }
    
        public int IDLOP { get; set; }
        public string MALOP { get; set; }
        public string TENLOP { get; set; }
        public string MAKHOA { get; set; }
        public string CHUYENNGANH { get; set; }
        public string TRAITHAILOP { get; set; }
        public int KHOAHOC { get; set; }
    
        public virtual KHOA KHOA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINH_VIEN> SINH_VIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THOIKHOABIEU> THOIKHOABIEUx { get; set; }
    }
}
