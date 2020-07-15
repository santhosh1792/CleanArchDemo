using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(confg =>
            {
                confg.AddProfile(new DomainToViewModelProfile());
                confg.AddProfile(new ViewModelToDomainProfile());
            });
        }
    }
}
