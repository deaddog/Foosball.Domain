namespace Foosball.Domain.Models.Tournaments
{
    public class EloScoring : IScoring
    {
        public EloScoring(int initialPoints, int kFactor)
        {
            InitialPoints = initialPoints;
            KFactor = kFactor;
        }

        public int InitialPoints { get; }
        public int KFactor { get; }
    }
}
