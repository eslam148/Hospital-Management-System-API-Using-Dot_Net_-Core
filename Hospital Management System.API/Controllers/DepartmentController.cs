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
    public class DepartmentController : ControllerBase
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;
        public DepartmentController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            
        }

        [Route("GetDepartmentsInHospital")]
        [HttpGet]
        public IActionResult Get() {
            var Department = unitOfWork.Department.GetAll();
            var re = mapper.Map<IEnumerable<DepartmentModel>>(Department);
            return Ok(re);
        }

        [Route("InsertDepartmentsInHospital")]
        [HttpPost]
        public IActionResult Post(DepartmentModel departmentmodel)
        {
           var department =  mapper.Map<Department>(departmentmodel);
            unitOfWork.Department.Add(department);
            if(unitOfWork.Save()==1)
            {
                return Created();
            }
            return BadRequest();
        }
    }
}
