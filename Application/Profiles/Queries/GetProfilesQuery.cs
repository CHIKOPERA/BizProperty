using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Profiles.Queries
{
    public record GetListingsQuery : IRequest<List<Profile>>;
   
    public class GetProfilesQueryHandler : IRequestHandler<GetListingsQuery, List<Profile>>
    {
        private readonly IApplicationDbContext _dbcontext;

        public GetProfilesQueryHandler(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Profile>> Handle(GetListingsQuery request, CancellationToken cancellationToken)=>  await  Task.FromResult( _dbcontext.Profiles.ToList());
        
    }
}
