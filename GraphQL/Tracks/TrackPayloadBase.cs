using System.Collections.Generic;
using ConferencePlanner.GraphQL.Common;
using ConferencePlanner.GraphQL.Data;
using HotChocolate.Types.Relay;

namespace ConferencePlanner.GraphQL.Tracks
{
    public class TrackPayloadBase : Payload
    {
        public TrackPayloadBase(Track track)
        {
            Track = track;
        }

        public TrackPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Track? Track { get; }
    }

    public record RenameTrackInput([ID(nameof(Track))] int Id, string Name);

    public class RenameTrackPayload : TrackPayloadBase
    {
        public RenameTrackPayload(Track track)
            : base(track)
        {
        }

        public RenameTrackPayload(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }
    }
}
