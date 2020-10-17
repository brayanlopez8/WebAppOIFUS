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
        public PersonaVM GetPersonaById(int id)
        {
            return MappingPeopleVM(unitOfWork.TblPersonaRepository.FindFirstWhere(c => c.Id == id), true);
        }
        public PersonaVM GetNewPersona()
        {
            return MappingPeopleVM(true);
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
            return MappingPeoplesVM(person);
        }

        private List<PersonaVM> MappingPeoplesVM(List<TblPersona> person)
        {
            List<PersonaVM> personaVMs = new List<PersonaVM>();
            foreach (var item in person)
            {
                PersonaVM persona = MappingPeopleVM(item);
                personaVMs.Add(persona);
            }
            return personaVMs;
        }
        private PersonaVM MappingPeopleVM(bool selectListFields = false)
        {
            PersonaVM persona = new PersonaVM();
            if (selectListFields)
            {
                persona = MappingPeopleVMSelectList(persona);
            }
            return persona;
        }
        private PersonaVM MappingPeopleVM(TblPersona item, bool selectListFields = false)
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
            if (selectListFields)
            {
                persona = MappingPeopleVMSelectList(persona);
            }
            return persona;
        }
        public PersonaVM MappingPeopleVMSelectList(PersonaVM persona)
        {
            persona.LstJornadaTrabajo = unitOfWork.TblJornadaDeTrabajoRepository.Getall().ToList();
            persona.LstTipoDocumento = unitOfWork.TblTipoDocumentoRepository.Getall().ToList();
            persona.LstGenero = unitOfWork.TblGeneroRepository.Getall().ToList();
            persona.LstOrientacionSexual = unitOfWork.TblOrientacionRepository.Getall().ToList();
            persona.LstIdentidadGenero = unitOfWork.TblIdentidaDeGeneroRepository.Getall().ToList();
            persona.LstJornadaTrabajo = unitOfWork.TblJornadaDeTrabajoRepository.Getall().ToList();
            persona.LstEtnia = unitOfWork.TblEtniaRepository.Getall().ToList();
            persona.LstLocalidad = unitOfWork.TblLocalidadViveRepository.Getall().ToList();
            persona.LstDiscapacidad = unitOfWork.TblDiscapacidadRepository.Getall().ToList();
            persona.LstTipoVivienda = unitOfWork.TblTipoDeViviendaRepository.Getall().ToList();
            persona.LstSeguridadSocial = unitOfWork.TblSeguridadSocialRepository.Getall().ToList();
            persona.LstEstratiSocioEconomico = unitOfWork.TblEstratoSocioEconomicoRepository.Getall().ToList();
            persona.LstLocalidadTrabajo = unitOfWork.TblLocalidadTrabajaRepository.Getall().ToList();
            persona.LstJornadaTrabajo = unitOfWork.TblJornadaDeTrabajoRepository.Getall().ToList();
            persona.LstTipoSubsidio = unitOfWork.TblSubsidioRepository.Getall().ToList();
            persona.LstNivielEscolaridad = unitOfWork.TblNivelDeEscolaridadRepository.Getall().ToList();
            return persona;
        }
    }
}
