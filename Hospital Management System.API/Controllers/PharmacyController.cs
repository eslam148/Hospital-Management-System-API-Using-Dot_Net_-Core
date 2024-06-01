using AutoMapper;
using Hospital_Management_System.API.Models;
using Hospital_Management_System.Domain;
using Hospital_Management_System.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacyController : ControllerBase
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;
        public PharmacyController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [Route("InsertPharmacy")]
        [HttpPost]
        public IActionResult Post(PharmacyModel pharmacymodel)
        {
            var pharmcy = mapper.Map<Pharmacy>(pharmacymodel);
            unitOfWork.Pharmacy.Add(pharmcy);
            if (unitOfWork.Save()==1)
            {
                return Created();
            }
            return BadRequest(pharmacymodel);
        }

        [Route("GetAllPharmacy")]
        [HttpGet]
        public IActionResult Get()
        {
            var Pharmacy = unitOfWork.Pharmacy.GetAll();
            var result = mapper.Map<List<PharmacyModel>>(Pharmacy);
            return Ok(result);
        }

        [Route("GetPharmacyByName")]
        [HttpGet]
        public IActionResult Get(string Name)
        {
            var Pharmacy = unitOfWork.Pharmacy.Find(x=>x.Name == Name).ToList();
            var result = mapper.Map<List<PharmacyModel>>(Pharmacy);
            return Ok(result);
        }
    }
}
