using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominion.Cards.Victory
{
    public interface IVictoryCard : ICard
    {
        int Points { get; }

        int EvaluateScore();
    }
}
