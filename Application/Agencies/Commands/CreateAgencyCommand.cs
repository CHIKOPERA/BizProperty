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

namespace Application.Agencies.Commands
{
    public class CreateAgentCommand : Agency ,IRequest<Agency>
    {
    }

    public class CreateAgencyCommandHandler : IRequestHandler<CreateAgentCommand, Agency>
    {
        private readonly IApplicationDbContext _dbContent;
        private readonly IMapper _mapper;

        public CreateAgencyCommandHandler(IApplicationDbContext dbContent,IMapper mapper)
        {
            this._dbContent = dbContent;
            this._mapper = mapper;
        }

        public Task<Agency> Handle(CreateAgentCommand request, CancellationToken cancellationToken)
        {
            Agency newAgency = new();
            _mapper.Map(request, newAgency);

            _dbContent.Agencies.Add(newAgency);

            return Task.FromResult( newAgency);
        
        }
    }

}
