using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure
{
    public class CQRSMappingProfile : Profile
    {
        public CQRSMappingProfile()
        {
            CreateMap<CreateTagBody, Tag>();
            CreateMap<Tag, CreateTagRequestResponse>();
        }
    }
}
