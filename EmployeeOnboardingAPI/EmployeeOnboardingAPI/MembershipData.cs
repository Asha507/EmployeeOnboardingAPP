//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeOnboardingAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class MembershipData
    {
        public string MDID { get; set; }
        public string UPID { get; set; }
        public string Association { get; set; }
        public string MembershipID { get; set; }
        public string MembershipType { get; set; }
        public string MembershipYear { get; set; }
        public string ValidUpto { get; set; }
        public string IsEdited { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
    }
}
