namespace TheSanctuary
{
    public class Player : PersonalData
    {
        public int GameModeScores;

        public PlayerTransform TransformData;
        public Force ThrowForce;
        public Outlook BallOutlook;

        public bool ReadyStatus = false;

        public Player(PersonalData Data)
        {
            login = Data.login;

            BallOutlook.BaseColor = Data.baseColor;
            BallOutlook.LinesColor = Data.linesColor;
            BallOutlook.PatternName = Data.patternName;
            BallOutlook.UsePattern = Data.usePattern;

            ThirtyThreeWinsCount = Data.ThirtyThreeWinsCount;
            ThreePointContestWinsCount = Data.ThreePointContestWinsCount;
            TimerChallengeWinsCount = Data.TimerChallengeWinsCount;
        }

        public void SetBallTransform(PlayerTransform transformData) => TransformData = transformData;

        public PlayerTransform GetBallTransform()
        {
            return TransformData;
        }

        public void SetBallOutlook(Outlook outlookData) => BallOutlook = outlookData;

        public Outlook GetBallOutlook()
        {
            return BallOutlook;
        }

        public void SetBallThrowForce(Force throwForce) => ThrowForce = throwForce;

        public Force GetBallThrowForce()
        {
            return ThrowForce;
        }

        public void SetGameReadyStatus(bool value) => ReadyStatus = value;
    }
}
