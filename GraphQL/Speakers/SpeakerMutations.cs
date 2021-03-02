using ConferencePlanner.GraphQL.Data;
using ConferencePlanner.GraphQL.Extensions;

using HotChocolate;
using HotChocolate.Types;

using System.Threading.Tasks;

namespace ConferencePlanner.GraphQL.Speakers
{
    [ExtendObjectType(Name = "Mutation")]
    public class SpeakerMutations
    {
        [UseApplicationDbContext]
        public async Task<AddSpeakerPayload> AddSpeakerAsync(
            AddSpeakerInput input,
            [ScopedService] ApplicationDbContext context)
        {
            var speaker = new Speaker
            {
                Name = input.Name,
                Bio = input.Bio,
                WebSite = input.Website
            };

            context.Speakers.Add(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        }

    }
}
