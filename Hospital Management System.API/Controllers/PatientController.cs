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
        public IActionResult UpdatePatient(Guid Id, PatientModel patientmodel)
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
            var patient = unitOfWork.Patient.Find(p => p.id == Id).FirstOrDefault();
            if (patient != null)
            {
                unitOfWork.Patient.Remove(patient);
                if (unitOfWork.Save() == 1)
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
        public IActionResult Get()
        {
            var patients = unitOfWork.Patient.GetAll();
            var result = _mapper.Map<IEnumerable<PatientModel>>(patients);
            return Ok(result);
        }

        [Route("GetById")]
        [HttpGet]
        public string GetById(Guid Id)
        {

            return Id.GetType().Name;
        }


        [Route("InserPatientDiagnoses")]
        [HttpPost]
        public IActionResult InserPatientDiagnoses(DiagnosesModel diagnosesmodel)
        {
            var diagnoses = _mapper.Map<Diagnoses>(diagnosesmodel);
            unitOfWork.Doiagnoses.Add(diagnoses);
            if (unitOfWork.Save() == 1)
            {
                return Created();
            }
            return BadRequest();
        }


        [Route("GetPatientDiagnoses")]
        [HttpGet]
        public IActionResult GetPatientDiagnoses(Guid PatientId)
        {
            var result = _mapper.Map<List<DiagnosesModel>>(unitOfWork.Doiagnoses.Find(x => x.PatientId == PatientId).ToList());
            return Ok(result);
        }
        [Route("InserPatientPharmacy")]
        [HttpPost]
        public IActionResult InserPatientPharmacy(Patient_PharmacyModel patient_PharmacyModel)
        {
            var x = new Patient_Pharmacy {
                PharmacyId =   patient_PharmacyModel.PharmacyId,
                PatientId = patient_PharmacyModel.PatientID,
                Amount = patient_PharmacyModel.Amount
            };
            unitOfWork.Patient_Pharmacy.Add(x);
            var y = unitOfWork.Pharmacy.GetById(patient_PharmacyModel.PharmacyId);
            if (y.Amount >= patient_PharmacyModel.Amount)
            {
                y.Amount-= patient_PharmacyModel.Amount;
                unitOfWork.Pharmacy.update(y);
                //var diagnoses = _mapper.Map<Diagnoses>(diagnosesmodel);
                //unitOfWork.Doiagnoses.Add(diagnoses);
                if (unitOfWork.Save() == 1)
                {
                    return Ok();
                }
            }
            else
            {
                return BadRequest("There Amount more than exist in Pharmacy");
            }

            return BadRequest();
        }


        [Route("GetPatientPharmacyByPatientId")]
        [HttpGet]
        public IActionResult GetPatientPharmacyByPatientId(Guid PatientId)
        {
            var result = _mapper.Map<List<Patient_PharmacyModel>>(unitOfWork.Patient_Pharmacy.Find(x => x.PatientId == PatientId).ToList());
            return Ok(result);
        }

        [Route("PatietnReservation")]
        [HttpPost]
        public IActionResult PatietnReservation(Guid PatientId)
        {
           
            return Created();
        }


        [Route("ReserveRoom")]
        [HttpPut]
        public IActionResult ReserveRoom(Guid PatientId,int RoomId)
        {
            var patient =  unitOfWork.Patient.GetById(PatientId);
            var room = unitOfWork.Room.GetById(RoomId);
            if(room.IsAvailable == false)
            {
                return BadRequest("Room is not avilable");
            }

            patient.RoomId = RoomId;
            unitOfWork.Patient.update(patient);
            if(unitOfWork.Save() == 1)
            {
                return Ok();

            }
            return BadRequest();
        }

    }
}
