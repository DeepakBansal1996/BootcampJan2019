//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Week2project.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> DesignationId { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public Nullable<int> DepartmentId { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Login_Credentials Login_Credentials { get; set; }
    }
}
