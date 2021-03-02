
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePlanner.GraphQL.Speakers
{
    public record AddSpeakerInput(string Name, string? Bio, string? Website);
}
