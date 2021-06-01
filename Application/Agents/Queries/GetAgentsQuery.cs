using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Atgents.Queries
{
    public record GetAgentsQuery : IRequest<List<Agent>>;
   
    public class GetAgentsQueryHandler : IRequestHandler<GetAgentsQuery, List<Agent>>
    {
        private readonly IApplicationDbContext _dbcontext;

        public GetAgentsQueryHandler(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Agent>> Handle(GetAgentsQuery request, CancellationToken cancellationToken)=>  await  Task.FromResult( _dbcontext.Agents.ToList());
        
    }
}
