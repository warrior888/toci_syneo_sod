//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toci.Syneo.Sod.Dal.Gatekeeper.Interfaces
{
    using System;
    using System.Collections.Generic;
    
    public partial class StoreOfDataPerForm
    {
        public int Id { get; set; }
        public Nullable<int> IdSodForms { get; set; }
        public string Data { get; set; }
        public string Metadata { get; set; }
        public string Document { get; set; }
    
        public virtual SodForm SodForm { get; set; }
    }
}
