using Foosball.Domain.Models.Matches;
using System;

namespace Foosball.Domain.Models.Tournaments.Rules
{
    public class ConfigurationRule : IRule
    {
        public ConfigurationRule(IConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public IConfiguration Configuration { get; }
    }
}
