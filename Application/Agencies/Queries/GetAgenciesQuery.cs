using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Agencies.Queries
{
    public record GetAgentsQuery : IRequest<List<Agency>>;
   
    public class GetProfilesQueryHandler : IRequestHandler<GetAgentsQuery, List<Agency>>
    {
        private readonly IApplicationDbContext _dbcontext;

        public GetProfilesQueryHandler(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Agency>> Handle(GetAgentsQuery request, CancellationToken cancellationToken)=>  await  Task.FromResult( _dbcontext.Agencies.ToList());
        
    }
}
