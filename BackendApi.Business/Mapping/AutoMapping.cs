using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BackendApi.Model.Dto;
using BackendApi.Model.Entity;

namespace BackendApi.Business.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<PersonDto, Person>();
        }
    }
}
