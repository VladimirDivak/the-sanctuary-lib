namespace TheSanctuary
{
    [System.Serializable]
    public struct Force
    {
        public float posX { get; set; }
        public float posY { get; set; }
        public float posZ { get; set; }

        public float rotX { get; set; }
        public float rotY { get; set; }
        public float rotZ { get; set; }

        public float torqueX { get; set; }
        public float torqueY { get; set; }
        public float torqueZ { get; set; }

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}