//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACarProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblSozlesme
    {
        public int SozlesmeID { get; set; }
        public string KiraSekli { get; set; }
        public Nullable<int> KiraGunSayisi { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
        public string AlisTarih { get; set; }
        public string TeslimTarih { get; set; }
        public Nullable<int> AracID { get; set; }
        public Nullable<int> MusteriID { get; set; }
    
        public virtual TblArac TblArac { get; set; }
        public virtual TblMusteri TblMusteri { get; set; }
    }
}
