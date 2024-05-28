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

        [Route("UpdatePatient")]
        [HttpPut]
        public IActionResult UpdatePatient(Guid Id,PatientModel patientmodel)
        {
            var patien = _mapper.Map<Patient>(patientmodel);
            patien.id = Id;
            unitOfWork.Patient.update(patien);
            if (unitOfWork.Save() == 1)
            {
                return Ok();
            }
            return BadRequest();
        }

        [Route("DeletePatient")]
        [HttpDelete]
        public IActionResult DeletePatient(Guid Id)
        {
           var patient =  unitOfWork.Patient.Find(p=>p.id == Id).FirstOrDefault();
            if(patient != null)
            {
                unitOfWork.Patient.Remove(patient);
                if(unitOfWork.Save() == 1)
                {
                    return Ok();
                }
                return BadRequest();

            }
            else
            {
                return NotFound();
            }
            
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

        [Route("GetById")]
        [HttpGet]
        public  string GetById(Guid Id)
        {

            return  Id.GetType().Name;
        }



    }
}
