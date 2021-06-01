using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Profile = Domain.Entities.Profile;

namespace Application.Listings.Commands
{
    public class UpdateListingCommnand : Listing,IRequest<Listing>
    {}
    public class UpdateListingCommnandHandler : IRequestHandler<UpdateListingCommnand, Listing>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _dbContext;

        public UpdateListingCommnandHandler(IMapper mapper, IApplicationDbContext dbContext)
        {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        public Task<Listing> Handle(UpdateListingCommnand request, CancellationToken cancellationToken)
        {            
            Listing listingToBeUpdated = _dbContext.Listings.FirstOrDefault(x => x.ListingId == request.ListingId);
            _mapper.Map(request, listingToBeUpdated);
            _dbContext.Listings.Update(listingToBeUpdated);
            return Task.FromResult(listingToBeUpdated);

        }
    }



}