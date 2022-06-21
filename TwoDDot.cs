namespace LearnOOP
{
    public record TwoDDot : Dot, IAddDot<TwoDDot>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TwoDDot(int x, int y)
        {
            this.Y = y;
            this.X = x;
        }
        public TwoDDot()
        {

        }

        public virtual TwoDDot AddDot(TwoDDot dot)
        {
            var res = new TwoDDot
            {
                X = this.X + dot.X,
                Y = this.Y + dot.Y
            };
            return res;
        }
        public int GetHo()
        {

        }
        public override string ToString()
        {
            var str = String.Format("X :{0} - Y :{1} ", this.X, this.Y);
            return str;
        }

        /// <summary>
        /// Adds two-dot fields together 
        /// </summary>
        /// <param name="t1">this is start dot</param>
        /// <param name="t2">this is start dot</param>
        /// <returns>new dot where Add result</returns>
        public TwoDDot AddDot(TwoDDot t1, TwoDDot t2)
        {
            throw new NotImplementedException();
        }

        public static TwoDDot operator +(TwoDDot t1, TwoDDot t2)
        {
            var res = new TwoDDot
            {
                X = t1.X + t2.X,
                Y = t1.Y + t2.Y
            };
            return res;
        }
    }
}