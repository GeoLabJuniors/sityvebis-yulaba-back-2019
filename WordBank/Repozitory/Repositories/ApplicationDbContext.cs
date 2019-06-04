using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Repozitory
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
        public DbSet<Word> Words { get; set; }

        public DbSet<Explanation> Explanations { get; set; }

        public DbSet<Example> Examples { get; set; }

        public DbSet<ContactInfo> Contacts { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}