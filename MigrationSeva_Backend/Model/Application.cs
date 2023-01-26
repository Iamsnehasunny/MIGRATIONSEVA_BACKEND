using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationSeva_Backend.Model
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public string gender { get; set; }
        public string Dob { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string PlacetoMigrate { get; set; }
        public string PurposetoMigrate { get; set; }
        public string AadharNumber { get; set; }
        public string Status { get; set; }
        public string RemarksByPolice { get; set; }

        public string DateofApplied { get; set; }

        public string DateofAdminStatus { get; set; }

        public string DateofPoliceStatus { get; set; }
    }
}
