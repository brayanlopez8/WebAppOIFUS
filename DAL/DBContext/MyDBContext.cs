using Audit.Core;
using Audit.EntityFramework;
using DAL.Migrations;
using DAL.Repository;
using ENT.Ent;
using ENT.Resources;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.DBContext
{
    public sealed class MyDBContext : AuditDbContext
    {
        private IConfiguration _configuration;
        public MyDBContext(DbContextOptions<MyDBContext> options, IConfiguration configuration) : base(options)
        {
            //Debugger.Launch();
            _configuration = configuration;
            defaultConfigDatabase();

        }
        public MyDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            defaultConfigDatabase();
        }

        public MyDBContext()
        {
            defaultConfigDatabase();
        }

        public void defaultConfigDatabase(IConfiguration configuration =  null) {
            if (configuration == null)
            {
                DbInitializer.Initialize(this);
            }
            //else {
            //    DbInitializer.Initialize(this, configuration);
            //}
            AuditEventType = "{database}_{context}";
            Mode = AuditOptionMode.OptOut;
            IncludeEntityObjects = false;
            Audit.Core.Configuration.DataProvider = new AuditProvider();
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Contactos> Contactos { get; set; }
        public DbSet<Notificaciones> Notificaciones { get; set; }
        public DbSet<TblPersona> tblPersona { get; set; }
        public DbSet<TblDiscapacidad> TblDiscapacidad { get; set; }
        public DbSet<TblLocalidadVive> TblLocalidadVive { get; set; }
        public DbSet<TblEtnia> TblEtnia { get; set; }
        public DbSet<TblIdentidaDeGenero> TblIdentidaDeGenero { get; set; }
        public DbSet<TblOrientacion> TblOrientacion { get; set; }
        public DbSet<TblGenero> TblGenero { get; set; }
        public DbSet<TblSubsidio> TblSubsidio { get; set; }
        public DbSet<TblTipoDocumento> TblTipoDocumento { get; set; }
        public DbSet<TblEstratoSocioEconomico> TblEstratoSocioEconomico { get; set; }
        public DbSet<TblNivelDeEscolaridad> TblNivelDeEscolaridad { get; set; }
        public DbSet<TblSeguridadSocial> TblSeguridadSocial { get; set; }
        public DbSet<TblTipoDeVivienda> TblTipoDeVivienda { get; set; }
        public DbSet<TblLocalidadTrabaja> TblLocalidadTrabaja { get; set; }
        public DbSet<TblJornadaDeTrabajo> TblJornadaDeTrabajo { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
           .UseSqlServer(_configuration.GetConnectionString("MyDBContext"));

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override void OnScopeSaving(AuditScope auditScope)
        {
            if (!Singleton.Instance.Audit) auditScope.Discard();
            auditScope.SetCustomField("Ip", Singleton.Instance.Ip);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken()) => base.SaveChangesAsync(cancellationToken);
    }
}
