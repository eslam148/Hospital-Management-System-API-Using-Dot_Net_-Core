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
    public class LaboratoryController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public LaboratoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [Route("InsertLab")]
        [HttpPost]
        public IActionResult post(LabModel labModel)
        {
            var lab = mapper.Map<Laboratory>(labModel);
            unitOfWork.Laboratory.Add(lab);
            if(unitOfWork.Save() == 1)
            {
                return Created();

            }
            return BadRequest();
        }

        [Route("GetLabByPatientId")]
        [HttpGet]
        public IActionResult Get(string PatienId)
        {
           
            var lab =  unitOfWork.Laboratory.GetLabByPatientId(PatienId);
            var re = mapper.Map<IEnumerable<LabModel>>(lab);
            return Ok(re);
        }

        [Route("UpdateLab")]
        [HttpPatch]
        public IActionResult patch(Guid LabId, string Result,string NormalRage)
        {

            var lab = unitOfWork.Laboratory.GetById(LabId);
            lab.result = Result;
            lab.NormalRang = NormalRage;
            unitOfWork.Laboratory.update(lab);
            if (unitOfWork.Save() == 1)
            {
                return Ok();

            }
            return BadRequest();
        }

        [Route("DeleteLab")]
        [HttpDelete]
        public IActionResult Delete(Guid LabId)
        {

            var lab = unitOfWork.Laboratory.GetById(LabId);
            unitOfWork.Laboratory.Remove(lab);
            if (unitOfWork.Save() == 1)
            {
                return Ok();

            }
            return BadRequest();
        }
    }
}
