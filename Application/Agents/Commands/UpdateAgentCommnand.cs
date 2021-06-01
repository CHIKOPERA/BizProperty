using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Agents.Commands
{
    public class UpdateAgentCommnand : IRequest<Agent>
    {
        public int Id { get; set; }
    }

    public class UpdateAgentCommnandHandler : IRequestHandler<UpdateAgentCommnand, Agent>
    {

      private readonly IMapper _mapper;
        private readonly IApplicationDbContext _dbContext;

        public UpdateAgentCommnandHandler(IMapper mapper, IApplicationDbContext dbContext)
        {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }
        public Task<Agent> Handle(UpdateAgentCommnand request, CancellationToken cancellationToken)
        {
            Agent agentToBeUpdated = _dbContext.Agents.FirstOrDefault(x => x.AgentId == request.Id);
            _mapper.Map(request, agentToBeUpdated);
            _dbContext.Agents.Update(agentToBeUpdated);
            return Task.FromResult(agentToBeUpdated);
        }
    }
}