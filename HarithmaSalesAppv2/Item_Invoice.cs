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
    
    public partial class Item_Invoice
    {
        public int Item_Invoice_ID { get; set; }
        public int ItemID { get; set; }
        public int InvoiceID { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Item Item { get; set; }
    }
}