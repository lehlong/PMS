using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PROJECT.Core.Common;
using PROJECT.Core.Models.AD;
using PROJECT.Core.Models.MD;
using System.IdentityModel.Tokens.Jwt;

namespace PROJECT.Core
{
    public class AppDbContext : DbContext
    {
        protected IHttpContextAccessor HttpContextAccessor { get; }
        public AppDbContext(DbContextOptions<AppDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            this.HttpContextAccessor = httpContextAccessor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations();
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public string UserProvider
        {
            get
            {
                //TODO
                return "";
            }
        }

        public Func<DateTime> TimestampProvider { get; set; } = ()
            => DateTime.UtcNow;

        public override int SaveChanges()
        {
            TrackChanges();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            TrackChanges();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void TrackChanges()
        {
            var token = HttpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString().Split(" ").ToList();
            var user = "";
            if (token.Count > 1)
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken securityToken = (JwtSecurityToken)tokenHandler.ReadToken(token[1]);
                var claim = securityToken.Claims;
                var result = claim.FirstOrDefault(x => x.Type == "username");
                user = result?.Value;
            }


            foreach (var entry in this.ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
            {
                if (entry.Entity is IBaseEntity)
                {
                    var auditable = entry.Entity as IBaseEntity;
                    if (entry.State == EntityState.Added)
                    {
                        auditable.CREATE_BY = user;
                        auditable.CREATE_DATE = TimestampProvider();
                    }
                    else
                    {
                        auditable.UPDATE_BY = user;
                        auditable.UPDATE_DATE = TimestampProvider();
                    }
                }
            }
        }

        #region System Manage
        public DbSet<T_AD_FORM> T_AD_FORM { get; set; }
        public DbSet<T_AD_FORM_OBJECT> T_AD_FORM_OBJECT { get; set; }
        public DbSet<T_AD_LANGUAGE_TRANSLATE> T_AD_LANGUAGE_TRANSLATE { get; set; }
        public DbSet<T_AD_LAST_SYN> T_AD_LAST_SYN { get; set; }
        public DbSet<T_AD_MENU> T_AD_MENU { get; set; }
        public DbSet<T_AD_MESSAGE> T_AD_MESSAGE { get; set; }
        public DbSet<T_AD_ORGANIZE> T_AD_ORGANIZE { get; set; }
        public DbSet<T_AD_RIGHT> T_AD_RIGHT { get; set; }
        public DbSet<T_AD_ROLE> T_AD_ROLE { get; set; }
        public DbSet<T_AD_ROLE_DETAIL> T_AD_ROLE_DETAIL { get; set; }
        public DbSet<T_AD_ROLE_TEMPLATE> T_AD_ROLE_TEMPLATE { get; set; }
        public DbSet<T_AD_ROLE_TEMPLATE_DETAIL> T_AD_ROLE_TEMPLATE_DETAIL { get; set; }
        public DbSet<T_AD_SYSTEM_CONFIG> T_AD_SYSTEM_CONFIG { get; set; }
        public DbSet<T_AD_USER> T_AD_USER { get; set; }
        public DbSet<T_AD_USER_CUSTOMER> T_AD_USER_CUSTOMER { get; set; }
        public DbSet<T_AD_USER_GROUP> T_AD_USER_GROUP { get; set; }
        public DbSet<T_AD_USER_GROUP_ROLE> T_AD_USER_GROUP_ROLE { get; set; }
        public DbSet<T_AD_USER_HISTORY> T_AD_USER_HISTORY { get; set; }
        public DbSet<T_AD_USER_ORG> T_AD_USER_ORG { get; set; }
        public DbSet<T_AD_USER_RIGHT> T_AD_USER_RIGHT { get; set; }
        public DbSet<T_AD_USER_ROLE> T_AD_USER_ROLE { get; set; }
        public DbSet<T_AD_USER_USER_GROUP> T_AD_USER_USER_GROUP { get; set; }
        public DbSet<T_AD_USER_VENDOR> T_AD_USER_VENDOR { get; set; }

        #endregion

        #region Master Data
        public DbSet<T_MD_BATCH> T_MD_BATCH { get; set; }
        public DbSet<T_MD_CONDITION> T_MD_CONDITION { get; set; }
        public DbSet<T_MD_CONTRACT> T_MD_CONTRACT { get; set; }
        public DbSet<T_MD_COUNTRY> T_MD_COUNTRY { get; set; }
        public DbSet<T_MD_CUSTOMER> T_MD_CUSTOMER { get; set; }
        public DbSet<T_MD_CUSTOMER_COMPANY> T_MD_CUSTOMER_COMPANY { get; set; }
        public DbSet<T_MD_CUSTOMER_TRANSFERED> T_MD_CUSTOMER_TRANSFERED { get; set; }
        public DbSet<T_MD_DC> T_MD_DC { get; set; }
        public DbSet<T_MD_DICTIONARY> T_MD_DICTIONARY { get; set; }
        public DbSet<T_MD_DISCHARD> T_MD_DISCHARD { get; set; }
        public DbSet<T_MD_DIVISION> T_MD_DIVISION { get; set; }
        public DbSet<T_MD_DOMAIN> T_MD_DOMAIN { get; set; }
        public DbSet<T_MD_MATERIAL> T_MD_MATERIAL { get; set; }
        public DbSet<T_MD_PAYMENT_TERM> T_MD_PAYMENT_TERM { get; set; }
        public DbSet<T_MD_PLANT> T_MD_PLANT { get; set; }
        public DbSet<T_MD_PO> T_MD_PO { get; set; }
        public DbSet<T_MD_POTYPE> T_MD_POTYPE { get; set; }
        public DbSet<T_MD_ROUTE> T_MD_ROUTE { get; set; }
        public DbSet<T_MD_SALEOFFICE> T_MD_SALEOFFICE { get; set; }
        public DbSet<T_MD_SHPOINT> T_MD_SHPOINT { get; set; }
        public DbSet<T_MD_SHTYPE> T_MD_SHTYPE { get; set; }
        public DbSet<T_MD_SLOCCH> T_MD_SLOCCH { get; set; }
        public DbSet<T_MD_SOTYPE> T_MD_SOTYPE { get; set; }
        public DbSet<T_MD_SO_CU_PLANT> T_MD_SO_CU_PLANT { get; set; }
        public DbSet<T_MD_SO_CU_VEHICLE> T_MD_SO_CU_VEHICLE { get; set; }
        public DbSet<T_MD_SO_CU_VENDOR> T_MD_SO_CU_VENDOR { get; set; }
        public DbSet<T_MD_STORE> T_MD_STORE { get; set; }
        public DbSet<T_MD_TRANSMODE> T_MD_TRANSMODE { get; set; }
        public DbSet<T_MD_TRANSUNIT> T_MD_TRANSUNIT { get; set; }
        public DbSet<T_MD_VEHICLE> T_MD_VEHICLE { get; set; }
        public DbSet<T_MD_UNIT> T_MD_UNIT { get; set; }
        public DbSet<T_MD_VEHICLE_COMPARTMENT> t_MD_VEHICLE_COMPARTMENT { get; set; }
        public DbSet<T_MD_VENDOR> T_MD_VENDOR { get; set; }
        public DbSet<T_MD_VENDOR_VEHICLE> T_MD_VENDOR_VEHICLE { get; set; }
        #endregion

    }
}
