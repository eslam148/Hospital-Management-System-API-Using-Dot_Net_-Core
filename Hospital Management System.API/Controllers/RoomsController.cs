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
    public class RoomsController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IUnitOfWork unitOfWork;
        public RoomsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [Route("InserRoom")]
        [HttpPost]
        public IActionResult Post(RoomModel roomModel) 
        {
            var room = _mapper.Map<Room>(roomModel);
            unitOfWork.Room.Add(room);
            if(unitOfWork.Save() == 1)
            {
                return Created();
            }
            else
            {
                return BadRequest();
            }
        }

        [Route("GetReservedRooms")]
        [HttpGet]
        public IActionResult GetReservedRooms(int HospitalID)
        {
           var rooms =  unitOfWork.Room.Find(r => r.IsAvailable == false && r.HospitalId == HospitalID).ToList();
            var result = _mapper.Map<List<RoomModel>>(rooms);
            return Ok(result);
        }

        [Route("GetAvailableRooms")]
        [HttpGet]
        public IActionResult GetAvailableRooms(int HospitalID)
        {
            var rooms = unitOfWork.Room.Find(r => r.IsAvailable == true && r.HospitalId == HospitalID).ToList();
            var result = _mapper.Map<List<RoomModel>>(rooms);
            return Ok(result);
        }
    }
}
