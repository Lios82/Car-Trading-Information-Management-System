//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesRecord
    {
        public int Id { get; set; }
        public string EngineNumber { get; set; }
        public string ChassisNumber { get; set; }
        public string Color { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> Paid { get; set; }
        public Nullable<decimal> Due { get; set; }
        public string Status { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> ModelId { get; set; }
    }
}
