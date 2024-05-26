using AutoMapper;
using Hospital_Management_System.Domain;
using Hospital_Management_System.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork unitOfWork;
        public PatientController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [Route("InserPatient")]
        [HttpPost]
        public IActionResult InserPatient(PatientModel patientmodel)
        {
            var patien = _mapper.Map<Patient>(patientmodel);
             unitOfWork.Patient.Add(patien);
            if (unitOfWork.Save() == 1)
            {
                return Created();
            }
            return BadRequest();
        }
        [Route("GetAdultPersons")]
        [HttpGet]
        public IEnumerable<Patient> GetAdultPersons()
        {
            return unitOfWork.Patient.GetAdultPatients();
        }
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return unitOfWork.Patient.GetAll();
        }

        [HttpPost]
        public int  Post(Patient item)
        {
            unitOfWork.Patient.Add(item);
           return unitOfWork.Save();
        }

    }
}
