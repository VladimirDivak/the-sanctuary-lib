using System;

namespace TheSanctuary.Interfaces
{
    public interface IGameMode
    {
        bool isMultiplayer { get; set; }
        int scoreMultiplier { get; set; }

        string GameDiscription();

        void StartGame();
        void EndGame();

        void OnGetScore();
        void OnBallGetParket();
    }
}