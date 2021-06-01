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

namespace Application.Agents.Commands
{
    public class CreateAgentCommand : Agent ,IRequest<Agent>
    {}

    public class CreateAgentCommandHandler : IRequestHandler<CreateAgentCommand, Agent>
    {
        private readonly IApplicationDbContext _dbContent;
        private readonly IMapper _mapper;

        public CreateAgentCommandHandler(IApplicationDbContext dbContent,IMapper mapper)
        {
            this._dbContent = dbContent;
            this._mapper = mapper;
        }

        public Task<Agent> Handle(CreateAgentCommand request, CancellationToken cancellationToken)
        {
            Agent newAgent = new();
            _mapper.Map(request, newAgent);

            _dbContent.Agents.Add(newAgent);

            return Task.FromResult(newAgent);
        
        }
    }

}
