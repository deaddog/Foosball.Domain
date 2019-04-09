namespace Foosball.Domain.Models
{
    public class Match
    {
        public Match(Id<Match> id, Participant participant1, Participant participant2)
        {
            Id = id ?? throw new System.ArgumentNullException(nameof(id));

            Participant1 = participant1 ?? throw new System.ArgumentNullException(nameof(participant1));
            Participant2 = participant2 ?? throw new System.ArgumentNullException(nameof(participant2));
        }

        public Id<Match> Id { get; }

        public Participant Participant1 { get; }
        public Participant Participant2 { get; }
    }
}
