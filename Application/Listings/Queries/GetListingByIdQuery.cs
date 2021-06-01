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
    public record GetListingByIdQuery(int id) : IRequest<Listing>;

    public class GetListingByIdQueryHandler : IRequestHandler<GetListingByIdQuery, Listing>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetListingByIdQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Listing> Handle(GetListingByIdQuery request, CancellationToken cancellationToken) => Task.FromResult(_dbContext.Listings.Where(x => x.ListingId == request.id).FirstOrDefault());
      
    }



}
