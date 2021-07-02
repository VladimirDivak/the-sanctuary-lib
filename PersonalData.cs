namespace TheSanctuary
{
    public class PersonalData
    {
        public string login { get; set; }

        // ball outlook data
        public string baseColor { get; set; }
        public string linesColor { get; set; }
        public string patternName { get; set; }
        public bool usePattern { get; set; }

        // player stats data
        public int ballThrowsCount { get; set; }
        public int ThirtyThreeWinsCount { get; set; }
        public int TimerChallengeWinsCount { get; set; }
        public int ThreePointContestWinsCount { get; set; }
    }
}
