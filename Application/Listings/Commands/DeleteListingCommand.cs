using Application.Common.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using Domain.Entities;
using System;
using MediatR;
using System.Linq;

namespace Application.Listings.Commands
{

    public record  DeleteListingCommand(int Id) : IRequest<bool>;

    public class DeleteListingCommandHandler : IRequestHandler<DeleteListingCommand, bool>
    {
        private readonly IApplicationDbContext _dbContext;

        public DeleteListingCommandHandler(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Task<bool> Handle(DeleteListingCommand request, CancellationToken cancellationToken)
        {
            Listing listingToBeDeleted = _dbContext.Listings.FirstOrDefault(x => x.ListingId == request.Id);

            _dbContext.Listings.Remove(listingToBeDeleted);
            return Task.FromResult(true);
        }
       
    }
}