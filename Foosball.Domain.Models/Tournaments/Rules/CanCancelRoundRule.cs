namespace Foosball.Domain.Models.Tournaments.Rules
{
    public class CanCancelRoundRule : IRule
    {
        public CanCancelRoundRule(bool whenStarted, bool whenEnded)
        {
            WhenStarted = whenStarted;
            WhenEnded = whenEnded;
        }

        public bool WhenStarted { get; }
        public bool WhenEnded { get; }
    }
}
