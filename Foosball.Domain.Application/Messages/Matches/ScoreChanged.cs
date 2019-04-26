using Foosball.Domain.Models;
using System;

namespace Foosball.Domain.Application.Messages.Matches
{
    public class ScoreChanged
    {
        public ScoreChanged(Id<Match> match, int score1, int score2)
        {
            if (score1 < 0) throw new ArgumentOutOfRangeException(nameof(score1), "Match score cannot be below zero.");
            if (score2 < 0) throw new ArgumentOutOfRangeException(nameof(score2), "Match score cannot be below zero.");

            Match = match ?? throw new ArgumentNullException(nameof(match));

            Score1 = score1;
            Score2 = score2;
        }

        public Id<Match> Match { get; }

        public int Score1 { get; }
        public int Score2 { get; }
    }
}
