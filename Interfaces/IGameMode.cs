using System;
using TheSanctuary.Network;

namespace TheSanctuary.Interfaces
{
    public interface IGameMode
    {
        NetworkGame gameInformation { get; set; }

        bool isMultiplayer { get; set; }
        int scoreMultiplier { get; set; }
        bool useBlockBallGrabbing { get; set; }
        bool UseDestroyBallAfterThrow { get; set; }

        float timeToStartThrowing { get; set; }
        float timeToReleaseThrowing { get; set; }

        float currentGameTime { get; set; }
        int currentGameScores { get; set; }

        string GetGameDiscription();

        void StartGame();
        void EndGame();

        void OnGetScore();
        void OnBallGetParket();
        void OnBallThrow();
    }
}