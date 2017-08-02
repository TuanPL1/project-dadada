using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Base;
using AutoMapper;
using DataAccess.Models;
using DataAccess.ViewModels;

namespace DataAccess.MapperRegister
{
    public class DataAccessMapperProfile : Profile
    { 
        public DataAccessMapperProfile()
        {
            CreateMap<JobDetails,JobDetailsObject>();
            
        }
    }
}
