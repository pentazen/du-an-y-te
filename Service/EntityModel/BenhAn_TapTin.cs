//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class BenhAn_TapTin
    {
        public int id_BenhAn { get; set; }
        public int id_TapTin { get; set; }
        public bool TrangThai { get; set; }
    
        public virtual BenhAn BenhAn { get; set; }
        public virtual TapTin TapTin { get; set; }
    }
}
