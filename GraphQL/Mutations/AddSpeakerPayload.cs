using ConferencePlanner.GraphQL.Data;

namespace ConferencePlanner.GraphQL.Mutations
{
    public class AddSpeakerPayload
    {
        public AddSpeakerPayload(Speaker speaker)
        {
            this.speaker = speaker;
        }

        public Speaker speaker { get; }
    }
}
