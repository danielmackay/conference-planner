using ConferencePlanner.GraphQL.Common;
using ConferencePlanner.GraphQL.Data;

using System.Collections.Generic;

namespace ConferencePlanner.GraphQL.Speakers
{
    public class SpeakerPayloadBase : Payload
    {
        public SpeakerPayloadBase(Speaker speaker)
        {
            Speaker = speaker;
        }

        protected SpeakerPayloadBase(IReadOnlyList<UserError> errors) 
            : base(errors)
        { 
        }

        public Speaker? Speaker { get; }
    }
}
