using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Agencies.Commands
{
    public class UpdateAgentCommnand : IRequest<Agency>
    {
        public int Id { get; set; }
    }

    public class UpdateAgencyCommnandHandler : IRequestHandler<UpdateAgentCommnand, Agency>
    {

      private readonly IMapper _mapper;
        private readonly IApplicationDbContext _dbContext;

        public UpdateAgencyCommnandHandler(IMapper mapper, IApplicationDbContext dbContext)
        {
            this._mapper = mapper;
            this._dbContext = dbContext;
        }
        public Task<Agency> Handle(UpdateAgentCommnand request, CancellationToken cancellationToken)
        {
            Agency agencyToBeUpdated = _dbContext.Agencies.FirstOrDefault(x => x.AgencyId == request.Id);
            _mapper.Map(request, agencyToBeUpdated);
            _dbContext.Agencies.Update(agencyToBeUpdated);
            return Task.FromResult(agencyToBeUpdated);
        }
    }
}