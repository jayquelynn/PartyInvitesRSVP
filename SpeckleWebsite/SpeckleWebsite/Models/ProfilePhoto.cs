//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpeckleWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfilePhoto
    {
        public Nullable<int> PhotoID { get; set; }
        public Nullable<int> ProfileID { get; set; }
        public int UserID { get; set; }
    
        public virtual Photo Photo { get; set; }
        public virtual ProfileDetail ProfileDetail { get; set; }
    }
}
