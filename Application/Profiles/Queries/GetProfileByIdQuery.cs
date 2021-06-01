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
    public record GetProfileByIdQuery(int id) : IRequest<Profile>;

    public class GetProfileByIdQueryHandler : IRequestHandler<GetProfileByIdQuery, Profile>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetProfileByIdQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Profile> Handle(GetProfileByIdQuery request, CancellationToken cancellationToken) => Task.FromResult(_dbContext.Profiles.Where(x => x.Id == request.id).FirstOrDefault());
      
    }



}
