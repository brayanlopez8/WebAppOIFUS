using DAL.DBContext;
using ENT.Ent;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        public UnitOfWork(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.context = new MyDBContext(configuration);
        }
       
        private bool disposed = false;
        private Repository<Person> personRepository;
        private Repository<Country> contryRepository;
        private Repository<Usuario> usuarioRepository;
        private Repository<Contactos> contactosRepository;
        private Repository<Notificaciones> notificacionesRepository;
        private Repository<TblPersona> tblPersonaRepository;
        private Repository<TblDiscapacidad> tblDiscapacidadRepository;
        private Repository<TblLocalidadVive> tblLocalidadViveRepository;
        private Repository<TblEtnia> tblEtniaRepository;
        private Repository<TblIdentidaDeGenero> tblIdentidaDeGeneroRepository;
        private Repository<TblOrientacion> tblOrientacionRepository;
        private Repository<TblGenero> tblGeneroRepository;
        private Repository<TblSubsidio> tblSubsidioRepository;
        private Repository<TblTipoDocumento> tblTipoDocumentoRepository;
        private Repository<TblEstratoSocioEconomico> tblEstratoSocioEconomicoRepository;
        private Repository<TblNivelDeEscolaridad> tblNivelDeEscolaridadRepository;
        private Repository<TblSeguridadSocial> tblSeguridadSocialRepository;
        private Repository<TblTipoDeVivienda> tblTipoDeViviendaRepository;
        private Repository<TblLocalidadTrabaja> tblLocalidadTrabajaRepository;
        private Repository<TblJornadaDeTrabajo> tblJornadaDeTrabajoRepository;
        private IConfiguration configuration;
        private MyDBContext context;

        //private MyDBContext context = new MyDBContext(configuration);

        public Repository<Country> CountryRepository
        {
            get
            {
                if (this.contryRepository == null)
                {
                    this.contryRepository = new Repository<Country>(context);
                }
                return contryRepository;
            }
        }
        public Repository<Person> PersonRepository
        {
            get
            {
                if (this.personRepository == null)
                {
                    this.personRepository = new Repository<Person>(context);
                }
                return personRepository;
            }
        }
        public Repository<Usuario> UsuarioRepository
        {
            get
            {
                if (this.usuarioRepository == null)
                {
                    this.usuarioRepository = new Repository<Usuario>(context);
                }
                return usuarioRepository;
            }
        }
        public Repository<Contactos> ContactosRepository
        {
            get
            {
                if (this.contactosRepository == null)
                {
                    this.contactosRepository = new Repository<Contactos>(context);
                }
                return contactosRepository;
            }
        }
        public Repository<Notificaciones> NotificacionesRepository
        {
            get
            {
                if (this.notificacionesRepository == null)
                {
                    this.notificacionesRepository = new Repository<Notificaciones>(context);
                }
                return notificacionesRepository;
            }
        }
        public Repository<TblPersona> TblPersonaRepository
        {
            get
            {
                if (this.tblPersonaRepository == null)
                {
                    this.tblPersonaRepository = new Repository<TblPersona>(context);
                }
                return tblPersonaRepository;
            }
        }
         

        public Repository<TblDiscapacidad> TblDiscapacidadRepository
        {
            get
            {
                if (this.tblDiscapacidadRepository == null)
                {
                    this.tblDiscapacidadRepository = new Repository<TblDiscapacidad>(context);
                }
                return tblDiscapacidadRepository;
            }
        }
        public Repository<TblLocalidadVive> TblLocalidadViveRepository
        {
            get
            {
                if (this.tblLocalidadViveRepository == null)
                {
                    this.tblLocalidadViveRepository = new Repository<TblLocalidadVive>(context);
                }
                return tblLocalidadViveRepository;
            }
        }
        public Repository<TblEtnia> TblEtniaRepository
        {
            get
            {
                if (this.tblEtniaRepository == null)
                {
                    this.tblEtniaRepository = new Repository<TblEtnia>(context);
                }
                return tblEtniaRepository;
            }
        }
        public Repository<TblIdentidaDeGenero> TblIdentidaDeGeneroRepository
        {
            get
            {
                if (this.tblIdentidaDeGeneroRepository == null)
                {
                    this.tblIdentidaDeGeneroRepository = new Repository<TblIdentidaDeGenero>(context);
                }
                return tblIdentidaDeGeneroRepository;
            }
        }
        public Repository<TblOrientacion> TblOrientacionRepository
        {
            get
            {
                if (this.tblOrientacionRepository == null)
                {
                    this.tblOrientacionRepository = new Repository<TblOrientacion>(context);
                }
                return tblOrientacionRepository;
            }
        }
        public Repository<TblGenero> TblGeneroRepository
        {
            get
            {
                if (this.tblGeneroRepository == null)
                {
                    this.tblGeneroRepository = new Repository<TblGenero>(context);
                }
                return tblGeneroRepository;
            }
        }
        public Repository<TblSubsidio> TblSubsidioRepository
        {
            get
            {
                if (this.tblSubsidioRepository == null)
                {
                    this.tblSubsidioRepository = new Repository<TblSubsidio>(context);
                }
                return tblSubsidioRepository;
            }
        }
        public Repository<TblTipoDocumento> TblTipoDocumentoRepository
        {
            get
            {
                if (this.tblTipoDocumentoRepository == null)
                {
                    this.tblTipoDocumentoRepository = new Repository<TblTipoDocumento>(context);
                }
                return tblTipoDocumentoRepository;
            }
        }


        public Repository<TblEstratoSocioEconomico> TblEstratoSocioEconomicoRepository
        {
            get
            {
                if (this.tblEstratoSocioEconomicoRepository == null)
                {
                    this.tblEstratoSocioEconomicoRepository = new Repository<TblEstratoSocioEconomico>(context);
                }
                return tblEstratoSocioEconomicoRepository;
            }
        }

        public Repository<TblNivelDeEscolaridad> TblNivelDeEscolaridadRepository
        {
            get
            {
                if (this.tblNivelDeEscolaridadRepository == null)
                {
                    this.tblNivelDeEscolaridadRepository = new Repository<TblNivelDeEscolaridad>(context);
                }
                return tblNivelDeEscolaridadRepository;
            }
        }

        public Repository<TblSeguridadSocial> TblSeguridadSocialRepository
        {
            get
            {
                if (this.tblSeguridadSocialRepository == null)
                {
                    this.tblSeguridadSocialRepository = new Repository<TblSeguridadSocial>(context);
                }
                return tblSeguridadSocialRepository;
            }
        }


        public Repository<TblTipoDeVivienda> TblTipoDeViviendaRepository
        {
            get
            {
                if (this.tblTipoDeViviendaRepository == null)
                {
                    this.tblTipoDeViviendaRepository = new Repository<TblTipoDeVivienda>(context);
                }
                return tblTipoDeViviendaRepository;
            }
        }

        public Repository<TblLocalidadTrabaja> TblLocalidadTrabajaRepository
        {
            get
            {
                if (this.tblLocalidadTrabajaRepository == null)
                {
                    this.tblLocalidadTrabajaRepository = new Repository<TblLocalidadTrabaja>(context);
                }
                return tblLocalidadTrabajaRepository;
            }
        }

        public Repository<TblJornadaDeTrabajo> TblJornadaDeTrabajoRepository
        {
            get
            {
                if (this.tblJornadaDeTrabajoRepository == null)
                {
                    this.tblJornadaDeTrabajoRepository = new Repository<TblJornadaDeTrabajo>(context);
                }
                return tblJornadaDeTrabajoRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
