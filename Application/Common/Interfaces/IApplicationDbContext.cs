using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Agent> Agents { get; set; }

        DbSet<Profile> Profiles { get; set; }
        DbSet<Listing> Listings { get; set; }
        DbSet<Agency> Agencies { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Anemity> Anemities { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
