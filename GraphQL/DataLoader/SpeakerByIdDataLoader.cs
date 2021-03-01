using ConferencePlanner.GraphQL.Data;

using GreenDonut;

using HotChocolate.DataLoader;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConferencePlanner.GraphQL.DataLoader
{
    public class SpeakerByIdDataLoader : BatchDataLoader<int, Speaker>
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbcontexFactory;

        public SpeakerByIdDataLoader(
            IBatchScheduler batchScheduler, 
            IDbContextFactory<ApplicationDbContext> dbContextFactory) 
            : base(batchScheduler)
        {
            _dbcontexFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<int, Speaker>> LoadBatchAsync(
            IReadOnlyList<int> keys, 
            CancellationToken cancellationToken)
        {
            await using ApplicationDbContext dbContext = _dbcontexFactory.CreateDbContext();

            return await dbContext.Speakers
                .Where(s => keys.Contains(s.Id))
                .ToDictionaryAsync(t => t.Id, cancellationToken);
        }
    }
}
