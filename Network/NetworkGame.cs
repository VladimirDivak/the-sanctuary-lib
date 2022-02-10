using System;

namespace TheSanctuary.Network
{
    [Serializable]
    public struct NetworkGame
    {
        public string name { get; set; }
        public uint bestScore { get; set; }
        public ushort bestTime { get; set; }
    }
}