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
    
    public partial class TainingData
    {
        public string TDID { get; set; }
        public string UPID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string TotalHours { get; set; }
        public string InstituteName { get; set; }
        public string TrainerName { get; set; }
        public string IsEdited { get; set; }
    
        public virtual UserProfile UserProfile { get; set; }
    }
}
