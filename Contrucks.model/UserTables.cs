using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;

namespace Contrucks.model
{
    public class UserTables :IdentityUser
    {
        [Key]
        public int PK_UserTableId { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [CustomEmailValidator]
        public string UserEmail { get; set; }
        [Required]
        public string UserPassword { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
   

}
