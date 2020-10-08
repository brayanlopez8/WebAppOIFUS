using AutoMapper;
using BLL.Interface;
using DAL.UnitOfWork;
using ENT.Ent;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.ViewModels;

namespace BLL.Implememtation
{
    public class PersonasBLL : IPersonaBLL
    {
        private UnitOfWork unitOfWork;
        private IConfiguration configuration;
        private IMapper iMapper = null;
        public PersonasBLL(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.unitOfWork = new UnitOfWork(configuration);
            var config = BLL.Automapper.AutoMapperConfig.ConfigurationAutomapper();
            iMapper = config.CreateMapper();

        }

        public TblPersona Create(TblPersona person)
        {
            return unitOfWork.TblPersonaRepository.add(person);
        }

        public Task<TblPersona> CreateAsync(TblPersona person)
        {
            return unitOfWork.TblPersonaRepository.addAsyc(person);
        }

        public TblPersona GetById(int id)
        {
            return unitOfWork.TblPersonaRepository.FindFirstWhere(c => c.Id == id);
        }

        public async Task<TblPersona> GetByIdAsync(int id)
        {
            var Persons = await unitOfWork.TblPersonaRepository.FindFirstWhereAsync(c => c.Id == id);
            return Persons;
        }

        public List<TblPersona> GetList()
        {
            return unitOfWork.TblPersonaRepository.Getall().ToList();
        }

        public async Task<List<TblPersona>> GetListAsync()
        {
            var Persons = await unitOfWork.TblPersonaRepository.GetallAsyc();
            return Persons.ToList();
        }

        public TblPersona Put(TblPersona person)
        {
            return unitOfWork.TblPersonaRepository.Update(person);
        }

        public async Task<TblPersona> PutAsync(TblPersona person)
        {
            var Persons = await unitOfWork.TblPersonaRepository.UpdateAsync(person);
            return Persons;
        }

        List<PersonaVM> IPersonaBLL.GetListVM()
        {
            var person = unitOfWork.TblPersonaRepository.Getall().ToList();
            return MappingPersonVM(person);
        }

        private List<PersonaVM> MappingPersonVM(List<TblPersona> person)
        {
            List<PersonaVM> personaVMs = new List<PersonaVM>();
            foreach (var item in person)
            {
                PersonaVM persona = new PersonaVM();
                persona = iMapper.Map<TblPersona, PersonaVM>(item);

                persona.TipoDocumento = unitOfWork.TblTipoDocumentoRepository.FindById(item.IdTipoDocumento.Value).Descripcion;
                persona.Genero = unitOfWork.TblGeneroRepository.FindById(item.ValidarGenero()).Descripcion;
                persona.OrientacionSexual = unitOfWork.TblOrientacionRepository.FindById(item.ValidarTipoDocumento()).Descripcion;
                persona.IdentidadGenero = unitOfWork.TblIdentidaDeGeneroRepository.FindById(item.ValidarIdentidadGenero()).Descripcion;
                persona.Etnia = unitOfWork.TblEtniaRepository.FindById(item.ValidarEtnia()).Descripcion;
                persona.Localidad = unitOfWork.TblLocalidadViveRepository.FindById(item.ValidarLocalidad()).Descripcion;
                persona.TipoDiscapacidad = unitOfWork.TblDiscapacidadRepository.FindById(item.ValidarTipoDiscapacidad()).Descripcion;
                persona.TipoVivienda = unitOfWork.TblTipoDeViviendaRepository.FindById(item.ValidarTipoVivienda()).Descripcion;
                persona.SeguridadSocial = unitOfWork.TblSeguridadSocialRepository.FindById(item.ValidarSeguridadSocial()).Descripcion;
                persona.NivielEscolaridad = unitOfWork.TblNivelDeEscolaridadRepository.FindById(item.ValidarNivielEscolaridad()).Descripcion;
                persona.EstratiSocioEconomico = unitOfWork.TblEstratoSocioEconomicoRepository.FindById(item.ValidarEstratiSocioEconomico()).Descripcion;
                persona.LocalidadTrabajo = unitOfWork.TblLocalidadTrabajaRepository.FindById(item.ValidarLocalidadTrabajo()).Descripcion;
                persona.JornadaTrabajo = unitOfWork.TblJornadaDeTrabajoRepository.FindById(item.ValidarJornadaTrabajo()).Descripcion;
                persona.TipoSubsidio = unitOfWork.TblSubsidioRepository.FindById(item.ValidarSubsidios()).Descripcion;
                personaVMs.Add(persona);

            }
            return personaVMs;
        }
    }
}
