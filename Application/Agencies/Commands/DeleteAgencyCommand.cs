using Application.Common.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using Domain.Entities;
using System;
using MediatR;
using System.Linq;

namespace Application.Agencies.Commands
{

    public record  DeleteAgencyCommand(int Id) : IRequest<bool>;

    public class DeleteProfileCommandHandler : IRequestHandler<DeleteAgencyCommand, bool>
    {
        private readonly IApplicationDbContext _dbContext;

        public DeleteProfileCommandHandler(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Task<bool> Handle(DeleteAgencyCommand request, CancellationToken cancellationToken)
        {
            Agency agency = _dbContext.Agencies.FirstOrDefault(x => x.AgencyId == request.Id);

            _dbContext.Agencies.Remove(agency);
            return Task.FromResult(true);
        }
       
    }
} 