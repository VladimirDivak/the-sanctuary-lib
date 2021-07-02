using System.Collections.Generic;

namespace TheSanctuary
{
    public enum MultiplayerMode
    {
        ThirtyThree,
        TimerChallenge,
        ThreePointContest
    }

    public interface IMode
    {
        int MaxPlayers { get; set; }
        int MaxScores { get; set; }
        Dictionary<string, Player> Players { get; set; }

        string[] OnGameInitialization(string[] methodArgs);
        string[] OnBallScoreGetting(string[] methodArgs);
        string[] OnBallParketGetting(string[] methodArgs);
        string[] OnGameEnding(string[] methodArgs);

        PlayerTransform OnPlayerMoving(string playerSessionId, PlayerTransform transformData);
        Force OnBallThrowning(string playerSessionId, Force throwForceData);
    }
}
