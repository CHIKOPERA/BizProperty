using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Profile = Domain.Entities.Profile;

namespace Application.Profiles.Commands
{
    public class UpdateListingCommnand : Profile,IRequest<Profile>
    {}

    public class UpdateProfileCommnandHandler : IRequestHandler<UpdateListingCommnand, Profile>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _dbContext;

        public UpdateProfileCommnandHandler(IMapper mapper, IApplicationDbContext dbContext)
        {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }

        public Task<Profile> Handle(UpdateListingCommnand request, CancellationToken cancellationToken)
        {            
            Profile profileToBeUpdated = _dbContext.Profiles.FirstOrDefault(x => x.ProfileId == request.ProfileId);
            _mapper.Map(request, profileToBeUpdated);
            _dbContext.Profiles.Update(profileToBeUpdated);
            return Task.FromResult(profileToBeUpdated);

        }
    }



}