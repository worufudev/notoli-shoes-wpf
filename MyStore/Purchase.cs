//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using PropertyChanged;

    public partial class Purchase
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase()
        {
            this.PurchaseDetails = new HashSet<PurchaseDetail>();
        }
    
        public int PurchaseID { get; set; }
        public Nullable<int> PurchaseCustomer { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<System.DateTime> PurchaseExpectedDeliveryDate { get; set; }
        public Nullable<System.DateTime> PurchaseReceivedDate { get; set; }
        public string PurchasePlace { get; set; }
        public Nullable<int> PurchaseTotal { get; set; }
        public Nullable<int> PurchaseStatus { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
