//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS
{
    using System;
    using System.Collections.Generic;
    
    public partial class SoldItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int SaleId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public string ItemSupplier { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<decimal> Discount { get; set; }
    
        public virtual Sale Sale { get; set; }
    }
}
