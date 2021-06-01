using Application.Common.Interfaces;
using System.Threading.Tasks;
using System.Threading;
using Domain.Entities;
using System;
using MediatR;
using System.Linq;

namespace Application.Profiles.Commands
{

    public record  DeleteProfileCommand(int Id) : IRequest<bool>;

    public class DeleteProfileCommandHandler : IRequestHandler<DeleteProfileCommand, bool>
    {
        private readonly IApplicationDbContext _dbContext;

        public DeleteProfileCommandHandler(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Task<bool> Handle(DeleteProfileCommand request, CancellationToken cancellationToken)
        {
            Profile profileToBeDeleted = _dbContext.Profiles.FirstOrDefault(x => x.ProfileId == request.Id);

            _dbContext.Profiles.Remove(profileToBeDeleted);
            return Task.FromResult(true);
        }
       
    }
}