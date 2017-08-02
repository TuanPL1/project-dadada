using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace DataAccess.MapperRegister
{
    public class DataAccessMapperConfiguration
    {
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DataAccessMapperProfile>();
            });
            return config;
        }
    }
}
