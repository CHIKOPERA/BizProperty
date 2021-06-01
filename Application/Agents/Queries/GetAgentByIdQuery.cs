using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Agents.Queries
{
    public record GetAgentByIdQuery(int id) : IRequest<Agent>;

    public class GetProfileByIdQueryHandler : IRequestHandler<GetAgentByIdQuery, Agent>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetProfileByIdQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Agent> Handle(GetAgentByIdQuery request, CancellationToken cancellationToken) => Task.FromResult(_dbContext.Agents.Where(x => x.AgentId == request.id).FirstOrDefault());
      
    }



}
