//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mini_Pjt_Shopping.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Carts = new HashSet<Cart>();
            this.Orders = new HashSet<Order>();
            this.Update_Products = new HashSet<Update_Products>();
            this.Wishlists = new HashSet<Wishlist>();
        }
    [DataMember]
        public int Prod_Id { get; set; }
        [DataMember]
        public Nullable<int> Category_Id { get; set; }
        [DataMember]
        public string Prod_Name { get; set; }
        [DataMember]
        public Nullable<decimal> Prod_Price { get; set; }
        [DataMember]
        public string Prod_Image { get; set; }
        [DataMember]
        public string Prod_Description { get; set; }
        [DataMember]
        public Nullable<int> Prod_Quantity { get; set; }
        [DataMember]
        public string Prod_Status { get; set; }
        [DataMember]
        public Nullable<int> Retail_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Retailer Retailer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Update_Products> Update_Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wishlist> Wishlists { get; set; }
        [DataMember]
        public string Category_Name { get; internal set; }
        [DataMember]
        public string Retail_Name { get; internal set; }
    }
}