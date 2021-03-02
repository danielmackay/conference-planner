using ConferencePlanner.GraphQL.Common;
using ConferencePlanner.GraphQL.Data;

using System.Collections.Generic;

namespace ConferencePlanner.GraphQL.Speakers
{
    public class AddSpeakerPayload : SpeakerPayloadBase
    {
        public AddSpeakerPayload(Speaker speaker)
            : base(speaker)
        {
        }

        public AddSpeakerPayload(IReadOnlyList<UserError> errors)
            : base(errors)
        { 
        }
    }
}
