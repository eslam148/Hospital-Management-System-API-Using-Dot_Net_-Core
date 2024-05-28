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
    public class HospitalController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public HospitalController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        [Route("GetHospitals")]
        [HttpGet]
        public IActionResult Get()
        {
            var Hospital = unitOfWork.Hospital.GetAll();
            var re = mapper.Map<IEnumerable<HospitalModel>>(Hospital);
            return Ok(re) ;
        }

        [Route("InsertHospitals")]
        [HttpPost]
        public IActionResult Post(HospitalModel hospitalModel)
        {
            var hospital = mapper.Map<Hospital>(hospitalModel);
            unitOfWork.Hospital.Add(hospital);
            if(unitOfWork.Save() == 1)
            {
                return Created();
            }
            return BadRequest();
        }
    }
}
