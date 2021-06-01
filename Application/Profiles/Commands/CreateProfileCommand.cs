using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Profile = Domain.Entities.Profile;

namespace Application.Person.Commands
{
    public class CreateProfileCommand : Profile ,IRequest<Profile>
    {
    }

    public class CreateProfileCommandHandler : IRequestHandler<CreateProfileCommand, Profile>
    {
        private readonly IApplicationDbContext _dbContent;
        private readonly IMapper _mapper;

        public CreateProfileCommandHandler(IApplicationDbContext dbContent,IMapper mapper)
        {
            this._dbContent = dbContent;
            this._mapper = mapper;
        }

        public Task<Profile> Handle(CreateProfileCommand request, CancellationToken cancellationToken)
        {
            Profile newProfile = new();
            _mapper.Map(request, newProfile);

            _dbContent.Profiles.Add(newProfile);

            return Task.FromResult( newProfile);
        
        }
    }

}
