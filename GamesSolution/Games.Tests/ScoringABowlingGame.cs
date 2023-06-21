using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Tests;

public class ScoringABowlingGame
{
    [Fact]
    public void Avacado()
    {
        var game = new BowlingGame();
        var p1 = new Player("Jeff", 212);
        var p2 = new Player("Stacey", 287);
        game.AddPlayer(p1.Name, p1.score);
        game.AddPlayer(p2.Name, p2.score);
        var expectedWinners = new List<Player> { p2 };
        var expectedLosers = new List<Player>() { p1 };
        var scorer = new GameScorer();
        ScoreReport report = scorer.GenerateScoreReportFor(game);
        Assert.Equal(expectedWinners, report.Winners);
        Assert.Equal(expectedLosers, report.Losers);
    }
}
