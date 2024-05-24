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
        private readonly IUnitOfWork unitOfWork;
        public PatientController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // GET: api/<PatientController>
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
