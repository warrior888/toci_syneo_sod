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
    
    public partial class SodUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SodUser()
        {
            this.SodUsersPriviledges = new HashSet<SodUsersPriviledge>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdSystemUsers { get; set; }
        public Nullable<int> IdUsersTypes { get; set; }
    
        public virtual SystemUser SystemUser { get; set; }
        public virtual UsersType UsersType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SodUsersPriviledge> SodUsersPriviledges { get; set; }
    }
}