using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.model.ViewModels
{
    public class UserTablesViewModel : IdentityDbContext
    {
        public string UserEmail { get; set; }
    
        public string UserPassword { get; set; }
    }
}
