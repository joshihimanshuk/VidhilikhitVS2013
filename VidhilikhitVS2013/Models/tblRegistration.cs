//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VidhilikhitVS2013.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRegistration
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<int> Age { get; set; }
        public string Religion { get; set; }
        public string MotherTounge { get; set; }
        public string Caste { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}