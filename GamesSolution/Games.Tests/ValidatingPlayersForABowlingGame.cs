﻿

namespace Games.Tests;
public class ValidatingPlayersForABowlingGame
{
    public class InvalidBowlingScoreException : ArgumentOutOfRangeException
    {

    }

    [Fact]
    public void DuplicateNamesAreNotAllowed()
    {
        
        // Given
        var game = new BowlingGame();

       
        game.AddPlayer("Jim", 120);
        game.AddPlayer("Sue", 200);

        
        // Then / When
      Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer(" jim ", 200));

    }

    [Theory]
    [InlineData(-1)]
    [InlineData(30)]
    public void InvalidScoreThrowAnException()
    {
        var game = new BowlingGame();
        Assert.Throws<InvalidBowlingScoreException>(() =>
            game.AddPlayer("Jim", -1)

    );
    }

}
