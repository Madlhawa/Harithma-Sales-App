//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HarithmaSalesAppv2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Discount
    {
        public int DiscountID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public decimal DiscountValue { get; set; }
        public Nullable<System.DateTime> DiscountStartDate { get; set; }
        public System.DateTime DiscountEndDate { get; set; }
        public Nullable<int> DiscountDuration { get; set; }
        public string DiscountStatus { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
