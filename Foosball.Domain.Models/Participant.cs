using System;
using System.Collections.Generic;

namespace Foosball.Domain.Models
{
    public class Participant : IEquatable<Participant>
    {
        private readonly Id<Player> _player;
        private readonly Team _team;

        public Participant(Id<Player> player)
        {
            _player = player ?? throw new ArgumentNullException(nameof(player));
            _team = null;
        }
        public Participant(Team team)
        {
            _team = team ?? throw new ArgumentNullException(nameof(team));
            _player = null;
        }

        public bool IsPlayer => _player != null;
        public bool IsTeam => _team != null;

        public TResult Match<TResult>(Func<Id<Player>, TResult> playerSelector, Func<Team, TResult> teamSelector)
        {
            if (IsPlayer) return playerSelector(_player);
            else if (IsTeam) return teamSelector(_team);
            else throw new InvalidOperationException();
        }
        public void Switch(Action<Id<Player>> playerAction, Action<Team> teamAction)
        {
            if (IsPlayer) playerAction(_player);
            else if (IsTeam) teamAction(_team);
            else throw new InvalidOperationException();
        }

        public static bool operator ==(Participant participant1, Participant participant2) => EqualityComparer<Participant>.Default.Equals(participant1, participant2);
        public static bool operator !=(Participant participant1, Participant participant2) => !(participant1 == participant2);

        public override bool Equals(object obj)
        {
            return Equals(obj as Participant);
        }
        public bool Equals(Participant other)
        {
            if (IsPlayer && other.IsPlayer)
                return _player.Equals(other._player);
            else if (IsTeam && other.IsTeam)
                return _team.Equals(other._team);
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Match(x => x.GetHashCode(), x => x.GetHashCode());
        }

        public override string ToString()
        {
            return Match(x => $"Player: {x}", x => $"Team: {x}");
        }
    }
}
