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
    
    public partial class AdditionalData
    {
        public string ADID { get; set; }
        public string UPID { get; set; }
        public string EmergencyContact { get; set; }
        public string PersonalContact { get; set; }
        public string DateofMarriage { get; set; }
        public string BloodGroup { get; set; }
        public string PersonalEmail { get; set; }
        public string PassportNumber { get; set; }
        public string PassportValidUpto { get; set; }
        public string PermenantAccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankAccountNumber { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
    }
}