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
    
    public partial class TINHLUONG
    {
        public int IDGV { get; set; }
        public int IDMH { get; set; }
        public int SOTIET { get; set; }
        public Nullable<decimal> SOTIENQUYDOI { get; set; }
    
        public virtual GIANG_VIEN GIANG_VIEN { get; set; }
        public virtual MON_HOC MON_HOC { get; set; }
    }
}
