//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTDD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class giohang
    {
        public string manm { get; set; }
        public string masp { get; set; }
        public int soluong { get; set; }
    
        public virtual nguoimua nguoimua { get; set; }
        public virtual sanpham sanpham { get; set; }
    }
}
