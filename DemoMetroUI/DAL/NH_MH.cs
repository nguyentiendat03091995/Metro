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
    
    public partial class NH_MH
    {
        public int IDMH { get; set; }
        public string MANGANH { get; set; }
        public string THELOAIMH { get; set; }
    
        public virtual MON_HOC MON_HOC { get; set; }
        public virtual NGANH_HOC NGANH_HOC { get; set; }
    }
}