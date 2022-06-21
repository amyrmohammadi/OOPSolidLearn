namespace LearnOOP
{
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public record ThreeDPoint : TwoDPoint, IAddPoint<ThreeDPoint>
    {
        public int Z { get; set; }

        public ThreeDPoint(int x, int y, int z) : base(x, y)
        {
            this.Z = z;
        }
        public ThreeDPoint()
        {

        }

        public override string ToString()
        {
            var str = String.Format("X :{0} - Y :{1} - Z :{2}", this.X, this.Y, this.Z);
            return str;
        }


        /// <summary>
        /// Add Point to current Point
        /// </summary>
        /// <param name="t1">this is Point</param>
        /// <returns>a threedPoint such as point(3,4) </returns>
        public ThreeDPoint AddPoint(ThreeDPoint t1)
        {
            var res = new ThreeDPoint
            {
                X = t1.X + this.X,
                Y = t1.Y + this.Y,
                Z = t1.Z + this.Z
            };
            return res;
        }

        public static ThreeDPoint operator +(ThreeDPoint d1, ThreeDPoint d2)
        {
            var res = new ThreeDPoint()
            {
                X = d1.X + d2.X,
                Y = d1.Y + d2.Y,
                Z = d1.Z + d2.Z
            };
            return res;
        }
    }
}
