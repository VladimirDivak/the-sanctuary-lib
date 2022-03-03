using System;
using System.Collections;
using System.Collections.Generic;

namespace TheSanctuary
{
    [Serializable]
    public class PlayerData
    {
        public string username { get; set; }
        public Outlook outlookData {get; set; }
        public float avgAccuracy { get; set; }
        public int level { get; set; }
        public int levelScores { get; set; }

        public List<NetworkGame> multiplayerGamesData { get; set; } = new List<NetworkGame>();
    }
}