using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Listing = Domain.Entities.Listing;
namespace Application.Listings.Commands
{
    public class CreateListingCommand : Listing, IRequest<Listing>
    {
    }

    public class CreateListingCommandHandler : IRequestHandler<CreateListingCommand, Listing>
    {
        private readonly IApplicationDbContext _dbContent;
        private readonly IMapper _mapper;

        public CreateListingCommandHandler(IApplicationDbContext dbContent,IMapper mapper)
        {
            this._dbContent = dbContent;
            this._mapper = mapper;
        }

        public Task<Listing> Handle(CreateListingCommand request, CancellationToken cancellationToken)
        {
            Listing newListing = new();
            _mapper.Map(request, newListing);

            _dbContent.Listings.Add(newListing);

            return Task.FromResult( newListing);
        
        }
    }

}
