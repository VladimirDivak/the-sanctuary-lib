namespace TheSanctuary
{
    public class RoomBase
    {
        public int ID { get; set; }
        public string CreatorSessionID { get; set; }
        public string GameModeName { get; set; }
        public int PlayersCounter { get; set; }
    }
}