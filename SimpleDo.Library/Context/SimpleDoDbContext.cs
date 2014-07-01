using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleDo.Library.Models; 

namespace SimpleDo.Library.Context
{
    public class SimpleDoDbContext : IdentityDbContext<User>
    {
    }
}
