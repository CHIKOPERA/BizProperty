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
    public record GetAgencyByIdQuery(int id) : IRequest<Agency>;

    public class GetProfileByIdQueryHandler : IRequestHandler<GetAgencyByIdQuery, Agency>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetProfileByIdQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Agency> Handle(GetAgencyByIdQuery request, CancellationToken cancellationToken) => Task.FromResult(_dbContext.Agencies.Where(x => x.AgencyId == request.id).FirstOrDefault());
      
    }



}
