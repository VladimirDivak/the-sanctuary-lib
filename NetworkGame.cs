using System;

namespace TheSanctuary
{
    [Serializable]
    public sealed class NetworkGame
    {
        public string name { get; set; }
        public int bestScore { get; set; }
        public float bestTime { get; set; }
    }
}