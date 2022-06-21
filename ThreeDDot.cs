namespace LearnOOP
{
    public record ThreeDDot : TwoDDot
    {
        public int Z { get; set; }

        public ThreeDDot(int x, int y, int z) : base(x, y)
        {
            this.Z = z;
        }
        public ThreeDDot()
        {

        }

        public  ThreeDDot AddDot(ThreeDDot dot)
        {
            var resDot = new ThreeDDot()
            {
                X = dot.X + this.X,
                Y = dot.Y + this.Y,
                Z = dot.Z + this.Z
            };
            return resDot;
        }

        public override string ToString()
        {
            var str = String.Format("X :{0} - Y :{1} - Z :{2}", this.X, this.Y, this.Z);
            return str;
        }

        public static ThreeDDot operator +(ThreeDDot d1, ThreeDDot d2)
        {
            var res = new ThreeDDot()
            {
                X = d1.X + d2.X,
                Y = d1.Y + d2.Y,
                Z = d1.Z + d2.Z
            };
            return res;
        }
        
    }
}