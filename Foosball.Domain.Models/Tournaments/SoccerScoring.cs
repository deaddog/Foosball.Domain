namespace Foosball.Domain.Models.Tournaments
{
    public class SoccerScoring : IScoring
    {
        public SoccerScoring() : this(3, 1, 0)
        {
        }
        public SoccerScoring(int victoryPoints, int drawPoints, int lossPoints)
        {
            VictoryPoints = victoryPoints;
            DrawPoints = drawPoints;
            LossPoints = lossPoints;
        }

        public int VictoryPoints { get; }
        public int DrawPoints { get; }
        public int LossPoints { get; }
    }
}
