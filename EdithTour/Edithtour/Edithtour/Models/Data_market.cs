//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Edithtour.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Data_market
    {
        public int ID_data_tour { get; set; }
        public Nullable<int> ID_service { get; set; }
        public Nullable<int> ID_order { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Service Service { get; set; }
    }
}
