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
    
    public partial class THOIKHOABIEU
    {
        public string MACH { get; set; }
        public int IDGV { get; set; }
        public int IDMH { get; set; }
        public int IDLOP { get; set; }
        public string MAPHONG { get; set; }
        public Nullable<System.DateTime> NGAYHOC { get; set; }
        public Nullable<System.TimeSpan> GIOBD { get; set; }
        public Nullable<System.TimeSpan> GIOKT { get; set; }
    
        public virtual CA_HOC CA_HOC { get; set; }
        public virtual GIANG_VIEN GIANG_VIEN { get; set; }
        public virtual LOP LOP { get; set; }
        public virtual MON_HOC MON_HOC { get; set; }
        public virtual PHONG_HOC PHONG_HOC { get; set; }
    }
}
