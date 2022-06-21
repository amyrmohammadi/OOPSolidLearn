namespace LearnOOP
{
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public record TwoDPoint : Point, IAddPoint<TwoDPoint>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TwoDPoint(int x, int y)
        {
            this.Y = y;
            this.X = x;
        }
        public TwoDPoint()
        {

        }
     
        public override string ToString()
        {
            var str = String.Format("X :{0} - Y :{1} ", this.X, this.Y);
            return str;
        }

        /// <summary>
        /// return The sum of the entry point  with the class object 
        /// </summary>
        /// <param name="t1">this is Point</param>
        /// <returns>A TwoDPoint that's the result of the plural.</returns>
        public TwoDPoint AddPoint(TwoDPoint t1)
        {
            var res = new TwoDPoint
            {
                X = t1.X + this.X,
                Y = t1.Y + this.Y
            };
            return res;
        }
       
        public static TwoDPoint operator +(TwoDPoint t1, TwoDPoint t2)
        {
            var res = new TwoDPoint
            {
                X = t1.X + t2.X,
                Y = t1.Y + t2.Y
            };
            return res;
        }

        public interface IAddPoint
        {
        }
    }
}