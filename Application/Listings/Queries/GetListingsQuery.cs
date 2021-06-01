using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Listings.Queries
{
    public record GetListingsQuery : IRequest<List<Listing>>;
   
    public class GetListingsQueryHandler : IRequestHandler<GetListingsQuery, List<Listing>>
    {
        private readonly IApplicationDbContext _dbcontext;

        public GetListingsQueryHandler(IApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Listing>> Handle(GetListingsQuery request, CancellationToken cancellationToken)=>  await  Task.FromResult( _dbcontext.Listings.ToList());

       
    }
}
