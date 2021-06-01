using Application.Common.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using Domain.Entities;
using System;
using MediatR;
using System.Linq;

namespace Application.Agents.Commands
{

    public record  DeleteAgentCommand(int Id) : IRequest<bool>;

    public class DeleteAgentCommandHandler : IRequestHandler<DeleteAgentCommand, bool>
    {
        private readonly IApplicationDbContext _dbContext;

        public DeleteAgentCommandHandler(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Task<bool> Handle(DeleteAgentCommand request, CancellationToken cancellationToken)
        {
            Agent agentToBeDeleted = _dbContext.Agents.FirstOrDefault(x => x.AgentId == request.Id);

            _dbContext.Agents.Remove(agentToBeDeleted);
            return Task.FromResult(true);
        }
       
    }
}