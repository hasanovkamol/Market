//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Market
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cities
    {
        public int City_ID { get; set; }
        public string City_name { get; set; }
        public string Country_Code { get; set; }
    
        public virtual Counties Counties { get; set; }
    }
}
