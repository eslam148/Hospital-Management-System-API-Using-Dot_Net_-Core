using AutoMapper;
using Hospital_Management_System.API.Models;
using Hospital_Management_System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.API.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Patient, PatientModel>()
            .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.PatientType))
            .ForMember(dest => dest.PatientType, opt => opt.MapFrom(src => src.PatientType))
            .ForMember(dest => dest.age, opt => opt.MapFrom(src => src.age))
            .ForMember(dest => dest.Discharge, opt => opt.MapFrom(src => src.Discharge))
            .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
            .ForMember(dest => dest.AdmitDate, opt => opt.MapFrom(src => src.AdmitDate));
         

            CreateMap<PatientModel, Patient>()
           .ForMember(dest => dest.id, opt => opt.Ignore())
           .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
           .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.PatientType))
           .ForMember(dest => dest.PatientType, opt => opt.MapFrom(src => src.PatientType))
           .ForMember(dest => dest.age, opt => opt.MapFrom(src => src.age))
           .ForMember(dest => dest.Discharge, opt => opt.MapFrom(src => src.Discharge))
           .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
           .ForMember(dest => dest.AdmitDate, opt => opt.MapFrom(src => src.AdmitDate))
           .ForMember(dest => dest.DoctorId, opt => opt.Ignore())
           .ForMember(dest => dest.RoomId, opt => opt.Ignore());

            CreateMap<Hospital, HospitalModel>();
            CreateMap<HospitalModel, Hospital>()
                .ForMember(dest => dest.id, opt => opt.Ignore()); ;

            CreateMap<Department, DepartmentModel>();
            CreateMap<DepartmentModel, Department>()
                .ForMember(dest => dest.id, opt => opt.Ignore()); ;

            CreateMap<Laboratory, LabModel>();
            CreateMap<LabModel, Laboratory>()
                .ForMember(dest => dest.id, opt => opt.Ignore()); ;
        }
    }
}
