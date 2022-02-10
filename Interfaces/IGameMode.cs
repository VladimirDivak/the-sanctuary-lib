using System;
using TheSanctuary.Network;

namespace TheSanctuary.Interfaces
{
    public interface IGameMode
    {
        NetworkGame gameInformation { get; set; }

        bool isMultiplayer { get; set; }
        int scoreMultiplier { get; set; }
        bool blockBallGrabbing { get; set; }
        bool destroyBallAfter { get; set; }

        string GetGameDiscription();

        void StartGame();
        void EndGame();

        void OnGetScore();
        void OnBallGetParket();
        void OnBallThrow();
    }
}