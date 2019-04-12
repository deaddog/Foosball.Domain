namespace Foosball.Domain.Models
{
    public class RoundScore : Score
    {
        public RoundScore(Id<Round> round, Id<Player> player, int addedPoints, int totalPoints)
            : base(player, totalPoints)
        {
            Round = round ?? throw new System.ArgumentNullException(nameof(round));
            AddedPoints = addedPoints;
        }

        public Id<Round> Round { get; }
        public int AddedPoints { get; }
    }
}
