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
        public List<float> throwAccuracyData { get; set; }
        public ulong winsValue {get; set; }
    }
}