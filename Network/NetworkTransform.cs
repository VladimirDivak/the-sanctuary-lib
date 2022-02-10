using System;

namespace TheSanctuary.Network
{
    [Serializable]
    public struct NetworkTransform
    {
        public float positionX { get; set; }
        public float positionY { get; set; }
        public float positionZ { get; set; }

        public float rotationX { get; set; }
        public float rotationY { get; set; }
        public float rotationZ { get; set; }

        public float velocityX { get; set; }
        public float velocityY { get; set; }
        public float velocityZ { get; set; }
    }
}