//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCompany.ModelFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.LineItems = new HashSet<LineItem>();
        }
    
        public int OrderId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string ShipToAddress { get; set; }
        public OrderSource OrderSource { get; set; }
        public int CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}