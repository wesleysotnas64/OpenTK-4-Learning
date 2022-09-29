namespace Classes.Vector
{
    public class Vector4
    {
        private float x;
        private float y;
        private float z;
        private float w;

        public Vector4(float _x = 0, float _y = 1, float _z = 0)
        {
            X = _x;
            Y = _y;
            Z = _z;
            W = 0;
        }

        

        public float X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public float Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public float Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public float W
        {
            get { return this.w; }
            private set { this.w = value; }
        }
    }
}