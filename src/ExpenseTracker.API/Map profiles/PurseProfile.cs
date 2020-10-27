﻿using AutoMapper;
using ExpenseTracker.API.Dtos.Purses;
using ExpenseTracker.Domain.Purses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.API.Map_profiles
{
    public class PurseProfile : Profile
    {
        public PurseProfile()
        {
            CreateMap<Purse, PurseDto>().IncludeAllDerived();
            CreateMap<PurseForUpdateDto, Purse>().IncludeAllDerived();
        }
    }
}
